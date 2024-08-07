-- -----------------------------------FUNCTIONS----------------------------

DELIMITER //
CREATE FUNCTION fn_FormatarCPF(p_cpf VARCHAR(11)) RETURNS VARCHAR(14)
DETERMINISTIC
BEGIN
    RETURN CONCAT(SUBSTRING(p_cpf, 1, 3), '.', SUBSTRING(p_cpf, 4, 3), '.', SUBSTRING(p_cpf, 7, 3), '-', SUBSTRING(p_cpf, 10, 2));
END //

CREATE FUNCTION fn_FormatarTelefone(p_telefone VARCHAR(11)) RETURNS VARCHAR(15)
DETERMINISTIC
BEGIN
    RETURN CONCAT('(', SUBSTRING(p_telefone, 1, 2), ') ', SUBSTRING(p_telefone, 3, 5), '-', SUBSTRING(p_telefone, 8, 4));
END //
DELIMITER ;

-- -----------------------------------VENDA----------------------------
-- VIEWS
CREATE OR REPLACE VIEW vw_ListarVendas AS
SELECT     
	v.id_venda, 
    c.nome AS nome_cliente,
    fn_FormatarCPF(c.cpf) AS cpf,
    fn_FormatarTelefone(c.telefone) AS telefone,
    v.data_venda,
    FORMAT(SUM(iv.quantidade * p.preco), 2, 'pt-BR') AS total,
    e.rua,
    e.bairro,
    e.cidade,
    e.cep,
    e.estado,
    e.numero
FROM venda v
JOIN item_venda iv ON v.id_venda = iv.id_venda
JOIN produto p ON iv.id_produto = p.id_produto
JOIN categoria ca ON p.id_categoria = ca.id_categoria
JOIN cliente c ON v.id_cliente = c.id_cliente
JOIN endereco e ON e.id_cliente = c.id_cliente
group by 
    v.id_venda, 
    v.id_cliente, 
    v.data_venda,
    e.id_endereco;

-- PROCEDURES
DELIMITER //
CREATE PROCEDURE sp_InsVenda (
    IN p_id_cliente INT,
    IN p_data DATETIME,
    OUT p_id_venda INT
)
BEGIN
    INSERT INTO Venda (id_cliente, data_venda) VALUES (p_id_cliente, p_data);
    SET p_id_venda = LAST_INSERT_ID();
END//

CREATE PROCEDURE sp_UpdVenda(
    IN p_id_cliente BIGINT,
    IN p_id_venda BIGINT,
    IN p_data DATETIME
)
BEGIN
    UPDATE venda SET id_cliente = p_id_cliente, data_venda = p_data WHERE id_venda = p_id_venda;
END //

CREATE PROCEDURE sp_DelVenda(
    IN p_id_venda BIGINT
)
BEGIN
    DELETE FROM venda WHERE id_venda = p_id_venda;
END //

CREATE PROCEDURE sp_ListarVendas(IN p_id_venda BIGINT, IN p_nome_cliente VARCHAR(50))
BEGIN
	IF p_nome_cliente IS NOT NULL THEN
		SELECT * FROM vw_ListarVendas WHERE nome_cliente LIKE CONCAT('%', p_nome_cliente, '%');
	ELSEIF p_id_venda IS NOT NULL THEN
		SELECT * FROM vw_ListarVendas WHERE id_venda = p_id_venda;
	ELSE
		SELECT * FROM vw_ListarVendas;
	END IF;
END //
DELIMITER ;

-- -----------------------------------ITEM-VENDA----------------------
-- VIEWS
CREATE OR REPLACE VIEW vw_ListarItens AS
SELECT 
	iv.id_venda,
	iv.id_produto,
	iv.quantidade, 
    p.nome AS nome,
    p.preco,
    (iv.quantidade * p.preco) AS subtotal
FROM item_venda iv
JOIN produto p ON iv.id_produto = p.id_produto
JOIN categoria c ON p.id_categoria = c.id_categoria;

-- PROCEDURES
DELIMITER //
CREATE PROCEDURE sp_InsItemVenda (
    IN p_id_produto BIGINT,
    IN p_id_venda BIGINT,
    IN p_quantidade INT
)
BEGIN
    INSERT INTO item_venda (id_produto, id_venda, quantidade) VALUES (p_id_produto, p_id_venda, p_quantidade);
END//

CREATE PROCEDURE sp_DelItemVenda(
    IN p_id_item BIGINT,
    IN p_id_venda BIGINT
)
BEGIN
	IF p_id_venda IS NOT NULL THEN
		DELETE FROM item_venda WHERE id_venda = p_id_venda;
	ELSE
		DELETE FROM item_venda WHERE id_item = p_id_item;
	END IF;
END //

CREATE PROCEDURE sp_ListarItens(IN p_id_venda BIGINT)
BEGIN
	IF p_id_venda IS NOT NULL THEN
		SELECT * FROM vw_ListarItens WHERE id_venda = p_id_venda;
	ELSE
		SELECT * FROM vw_ListarProdutos;
	END IF;
END //
DELIMITER ;

-- -----------------------------------PRODUTO--------------------------
-- VIEWS
CREATE OR REPLACE VIEW vw_ListarProdutos AS
SELECT p.id_produto, p.id_categoria, p.nome, p.preco, c.nome AS nome_categoria 
FROM produto p
JOIN categoria c ON p.id_categoria = c.id_categoria;

-- PROCEDURES
DELIMITER //
CREATE PROCEDURE sp_InsProduto(
    IN p_id_categoria BIGINT,
    IN p_nome VARCHAR(50),
    IN p_preco FLOAT
)
BEGIN
    INSERT INTO produto (id_categoria, nome, preco) VALUES (p_id_categoria, p_nome, p_preco);
END //

CREATE PROCEDURE sp_UpdProduto(
    IN p_id_produto BIGINT,
    IN p_id_categoria BIGINT,
    IN p_nome VARCHAR(50),
    IN p_preco FLOAT
)
BEGIN
    UPDATE produto SET id_categoria = p_id_categoria, nome = p_nome, preco = p_preco WHERE id_produto = p_id_produto;
END //

CREATE PROCEDURE sp_DelProduto(
    IN p_id_produto BIGINT
)
BEGIN
    DELETE FROM produto WHERE id_produto = p_id_produto;
END //

CREATE PROCEDURE sp_ListarProdutos(IN p_id_produto BIGINT, IN p_nome_produto VARCHAR(50))
BEGIN
	IF p_nome_produto IS NOT NULL THEN
		SELECT * FROM vw_ListarProdutos WHERE nome LIKE CONCAT('%', p_nome_produto, '%');
	ELSEIF p_id_produto IS NOT NULL THEN
		SELECT * FROM vw_ListarProdutos WHERE id_produto = p_id_produto;
	ELSE
		SELECT * FROM vw_ListarProdutos;
	END IF;
END //
DELIMITER ;

-- -------------- --------------------CATEGORIA-------------------------
-- VIEWS
CREATE OR REPLACE VIEW vw_ListarCategorias AS
SELECT * FROM categoria;

-- PROCEDURES
DELIMITER //
CREATE PROCEDURE sp_InsCategoria(
    IN p_nome VARCHAR(50)
)
BEGIN
    INSERT INTO categoria (nome) VALUES (p_nome);
END //

CREATE PROCEDURE sp_UpdCategoria(
    IN p_id_categoria BIGINT,
    IN p_nome VARCHAR(50)
)
BEGIN
    UPDATE categoria SET nome = p_nome WHERE id_categoria = p_id_categoria;
END //

CREATE PROCEDURE sp_DelCategoria(
    IN p_id_categoria BIGINT
)
BEGIN
    DELETE FROM categoria WHERE id_categoria = p_id_categoria;
END //

CREATE PROCEDURE sp_ListarCategorias(IN p_id_categoria BIGINT, IN p_nome_categoria VARCHAR(50))
BEGIN
	IF p_nome_categoria IS NOT NULL THEN
		SELECT * FROM vw_ListarCategorias WHERE nome LIKE CONCAT('%', p_nome_categoria, '%');
	ELSEIF p_id_categoria IS NOT NULL THEN
		SELECT * FROM vw_ListarCategorias WHERE id_cliente = p_id_categoria;
	ELSE
		SELECT * FROM vw_ListarCategorias;
	END IF;
END //
DELIMITER ;

-- ------------------------------------CLIENTE--------------------------

-- VIEWS
CREATE OR REPLACE VIEW vw_ListarClientes AS
SELECT c.id_cliente, c.nome, fn_FormatarTelefone(c.telefone) AS telefone, fn_FormatarCPF(c.cpf) AS cpf, e.rua, e.numero, e.bairro, e.cidade, e.estado, e.cep
FROM cliente c
LEFT JOIN endereco e ON c.id_cliente = e.id_cliente;

-- PROCEDURES
DELIMITER //
CREATE PROCEDURE sp_InsCliente(
    IN p_nome VARCHAR(50),
    IN p_telefone VARCHAR(11),
    IN p_cpf VARCHAR(11),
    IN p_rua VARCHAR(100),
    IN p_numero VARCHAR(5),
    IN p_bairro VARCHAR(100),
    IN p_cidade VARCHAR(100),
    IN p_estado VARCHAR(2),
    IN p_cep VARCHAR(8)
)
BEGIN
    DECLARE new_id BIGINT;
    INSERT INTO cliente (nome, telefone, cpf) VALUES (p_nome, p_telefone, p_cpf);
    SET new_id = LAST_INSERT_ID();
    INSERT INTO endereco (id_cliente, rua, numero, bairro, cidade, estado, cep) VALUES (new_id, p_rua, p_numero, p_bairro, p_cidade, p_estado, p_cep);
END //

CREATE PROCEDURE sp_UpdCliente(
    IN p_id_cliente BIGINT,
    IN p_nome VARCHAR(50),
    IN p_telefone VARCHAR(11),
    IN p_cpf VARCHAR(11),
    IN p_rua VARCHAR(100),
    IN p_numero VARCHAR(5),
    IN p_bairro VARCHAR(100),
    IN p_cidade VARCHAR(100),
    IN p_estado VARCHAR(2),
    IN p_cep VARCHAR(8)
)
BEGIN
    UPDATE cliente SET nome = p_nome, telefone = p_telefone, cpf = p_cpf WHERE id_cliente = p_id_cliente;
    UPDATE endereco SET rua = p_rua, numero = p_numero, bairro = p_bairro, cidade = p_cidade, estado = p_estado, cep = p_cep WHERE id_cliente = p_id_cliente;
END //

CREATE PROCEDURE sp_DelCliente(
    IN p_id_cliente BIGINT
)
BEGIN
    DELETE FROM endereco WHERE id_cliente = p_id_cliente;
    DELETE FROM cliente WHERE id_cliente = p_id_cliente;
END //

CREATE PROCEDURE sp_ListarClientes(IN p_id_cliente BIGINT, IN p_nome_cliente VARCHAR(50))
BEGIN
	IF p_nome_cliente IS NOT NULL THEN
		SELECT * FROM vw_ListarClientes WHERE nome LIKE CONCAT('%', p_nome_cliente, '%');
	ELSEIF p_id_cliente IS NOT NULL THEN
		SELECT * FROM vw_ListarClientes WHERE id_cliente = p_id_cliente;
	ELSE
		SELECT * FROM vw_ListarClientes;
	END IF;
END //
DELIMITER ;