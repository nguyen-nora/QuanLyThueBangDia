CREATE TABLE TheLoai (
  TheLoaiID serial,
  Name text NOT NULL,
  PRIMARY KEY (TheLoaiID)
);

CREATE TABLE BangDia (
  BangDiaID serial,
  Name text NOT NULL,
  TheLoaiID int NOT NULL,
  Price DECIMAL(10,2) NOT NULL,
  Quantity INT NOT NULL,
  Status VARCHAR(255) NOT NULL,
  PRIMARY KEY (BangDiaID),
  FOREIGN KEY (TheLoaiID) REFERENCES TheLoai (TheLoaiID)
);

SET datestyle = "ISO, DMY";

CREATE TABLE PhieuThue (
	PhieuThueID serial,
	Name text NOT NULL,
	Phone varchar(255),
	TradeD TIMESTAMP NOT NULL,
	PayD TIMESTAMP,
	Total DECIMAL(10,2) NOT NULL,
	StatusPT varchar(255) NOT NULL,
	PRIMARY KEY (PhieuThueID)
);

CREATE TABLE ChiTietPhieuThue (
	PhieuThueID int  REFERENCES PhieuThue (PhieuThueID),
	BangDiaID int REFERENCES BangDia (BangDiaID),
	SoLuong int,
	PRIMARY KEY (PhieuThueID, BangDiaID)
);

INSERT INTO ChiTietPhieuThue VALUES (1, 3, 1);

	

INSERT INTO TheLoai (Name) VALUES
('Action'),
('Adventure'),
('Comedy'),
('Drama'),
('Family');

INSERT INTO BangDia (Name, TheLoaiID, Price, Quantity, Status)
VALUES
('The Book Thief', 1, 19.99, 10, 'In Stock'),
('To Kill a Mockingbird', 1, 17.99, 5, 'In Stock'),
('The Hunger Games', 2, 14.99, 20, 'In Stock'),
('Harry Potter and the Sorcerer''s Stone', 3, 12.99, 30, 'In Stock'),
('The Lord of the Rings: The Fellowship of the Ring', 4, 10.99, 40, 'In Stock');

INSERT INTO PhieuThue (Name, Phone, TradeD, PayD, Total, StatusPT) VALUES
('John Doe', '123-456-7890', '27-05-2023', NULL, 100.00, 'Paid'),
('Jane Doe', '555-555-5555', '28-06-2023', '30-06-2023', 200.00, 'Rent');


INSERT INTO ChiTietPhieuThue (PhieuThueID, BangDiaID, SoLuong) VALUES
(1, 1, 1),
(1, 2, 3),
(2, 3, 2),
(2, 4, 1);



/* -------------------------- Detail Product ---------------------------- */

CREATE OR REPLACE FUNCTION get_bangdia_details()
RETURNS TABLE (
  BangDiaID int,
  Name text,
  N_TheLoai text,
  Price decimal(10,2),
  Quantity int,
  Status varchar(255)
) 
LANGUAGE plpgsql
AS $$
BEGIN
  RETURN QUERY
    SELECT
      b.BangDiaID,
      b.Name,
      t.Name AS N_TheLoai,
      b.Price,
      b.Quantity,
      b.Status
    FROM BangDia b
    INNER JOIN TheLoai t ON b.TheLoaiID = t.TheLoaiID;
END;
$$

/* -------------------------- Detail Customer ---------------------------- */

CREATE FUNCTION get_chitietphieuthue(PhieuThueID int) 
RETURNS TABLE (
  PhieuThue_Name text,
  BangDia_Name text,
  SoLuong int
) 
LANGUAGE plpgsql
AS $$
BEGIN
  RETURN QUERY
    SELECT
      p.Name AS PhieuThue_Name,
      b.Name AS BangDia_Name,
      ct.SoLuong
    FROM ChiTietPhieuThue ct
	INNER JOIN BangDia b ON ct.BangDiaID = b.BangDiaID
	INNER JOIN PhieuThue p ON ct.PhieuThueID = p.PhieuThueID
	WHERE PhieuThueID = $1; 
END;
$$

CREATE TABLE ChiTietPhieuThue (
	PhieuThueID int  REFERENCES PhieuThue (PhieuThueID),
	BangDiaID int REFERENCES BangDia (BangDiaID),
	SoLuong int,
	PRIMARY KEY (PhieuThueID, BangDiaID)
);

/* -------------------------- Add Product ---------------------------- */
CREATE or REPLACE PROCEDURE  add_product(
  name text,
  TheLoaiID int,
  price decimal(10,2),
  quantity int,
  status varchar(255)
)
LANGUAGE plpgsql
AS $$
BEGIN

  -- Check if the product name already exists.
  IF EXISTS (
    SELECT 1
    FROM BangDia
    WHERE BangDia.name = $1
  ) THEN

    RAISE EXCEPTION 'Product name already exists.';

  END IF;

  -- Insert the new product into the table.
  INSERT INTO BangDia (name, TheLoaiID, price, quantity, status)
  VALUES ($1, $2, $3, $4, $5);

END;
$$

  --Insert
CALL add_product('The Lord Dragon', 4, 13.99, 40, 'In Stock');

/* -------------------------- Update Product ---------------------------- */
CREATE OR REPLACE PROCEDURE update_product(
    up_product_id int,
    up_name text,
    up_theloai_id int,
    up_price decimal(10,2),
    up_quantity int,
    up_status varchar(255)
)
LANGUAGE plpgsql
AS $$
BEGIN
    UPDATE BangDia
    SET name = up_name,
        TheLoaiID = up_theloai_id,
        price = up_price,
        quantity = up_quantity,
        status = up_status
    WHERE BangDia.BangDiaID = up_product_id;
END;
$$

CALL update_product(1, 'New Name', 2, 10.00, 10, 'In Stock');

/* -------------------------- Delete Product ---------------------------- */
CREATE OR REPLACE PROCEDURE delete_product(product_id int)
LANGUAGE plpgsql
AS $$
BEGIN
  -- Check if the product exists
  IF NOT EXISTS (SELECT 1 FROM BangDia WHERE BangDiaID = product_id) THEN
    RAISE EXCEPTION 'Product does not exist';
  END IF;

  -- Delete the product
  DELETE FROM BangDia WHERE BangDiaID = product_id;

  -- Return success
  RETURN;
END;
$$

/* -------------------------- Add Category ---------------------------- */
CREATE or REPLACE PROCEDURE  add_category(
  name text
)
LANGUAGE plpgsql
AS $$
BEGIN

  -- Check if the product name already exists.
  IF EXISTS (
    SELECT 1
    FROM TheLoai
    WHERE TheLoai.name = $1
  ) THEN

    RAISE EXCEPTION 'Product name already exists.';

  END IF;

  -- Insert the new product into the table.
  INSERT INTO TheLoai (name)
  VALUES ($1);

END;
$$

  --Insert
CALL add_category('Anime');

/* -------------------------- Update Category ---------------------------- */
CREATE OR REPLACE PROCEDURE update_category(
    up_category_id int,
    up_name text
)
LANGUAGE plpgsql
AS $$
BEGIN
    UPDATE TheLoai	
    SET name = up_name
    WHERE TheLoai.TheLoaiID = up_category_id;
END;
$$

CALL update_product(1, 'Count');

/* -------------------------- Delete Category ---------------------------- */
CREATE OR REPLACE PROCEDURE delete_category(category_id int)
LANGUAGE plpgsql
AS $$
BEGIN
  -- Check if the product exists
  IF NOT EXISTS (SELECT 1 FROM TheLoai WHERE TheLoaiID = product_id) THEN
    RAISE EXCEPTION 'Product does not exist';
  END IF;

  -- Delete the product
  DELETE FROM TheLoai WHERE TheLoaiID = product_id;

  -- Return success
  RETURN;
END;
$$

/* -------------------------- Add Customer ---------------------------- */
CREATE or REPLACE PROCEDURE  add_customer(
  name text,
  phone varchar(255),
  traded TIMESTAMP,
  payd TIMESTAMP,
  total DECIMAL(10,2),
  statuspt varchar(255)
)
LANGUAGE plpgsql
AS $$
BEGIN

  -- Insert the new product into the table.
  INSERT INTO PhieuThue (name, phone, traded, payd, total, statuspt)
  VALUES ($1, $2, $3, $4, $5, $6);

END;
$$

  --Insert
CALL add_customer('Jack Doe', '555-555-5555', '28-06-2023', '30-06-2023', 200.00, 'Rent');

/* -------------------------- Get PhieuThueID ---------------------------- */
CREATE OR REPLACE FUNCTION get_phieuthueid(
	g_name text, 
	g_phone varchar(255), 
	g_traded timestamp
)
RETURNS int
LANGUAGE plpgsql
AS $$
BEGIN
  RETURN (
    SELECT PhieuThueID
    FROM PhieuThue
    WHERE PhieuThue.Name = g_name
      AND PhieuThue.Phone = g_phone
      AND PhieuThue.TradeD = g_traded
  );

END
$$ 

SELECT get_phieuthueid('John Doe', '123-456-7890', '2023-05-27');

/* -------------------------- Add ChiTietPhieuThue ---------------------------- */
CREATE OR REPLACE PROCEDURE add_ChiTietPhieuThue(
  PhieuThueID int,
  BangDiaID int,
  SoLuong int
)
LANGUAGE plpgsql
AS $$
BEGIN
	INSERT INTO ChiTietPhieuThue (PhieuThueID, BangDiaID, SoLuong) 
	VALUES ($1, $2, $3);
END;
$$

CALL add_ChiTietPhieuThue(1, 3, 3);

/* -------------------------- Update PhieuThue ---------------------------- */
CREATE OR REPLACE PROCEDURE update_phieuthue(
  up_phieuthueid int,
  up_name text,
  up_phone varchar(255),
  up_traded timestamp,
  up_payd timestamp,
  up_total decimal(10,2),
  up_statuspt varchar(255)
)
LANGUAGE plpgsql
AS $$
BEGIN
  -- Update the PhieuThue table with the given values.
  UPDATE PhieuThue
  SET name = up_name,
      phone = up_phone,
      traded = up_traded,
      payd = up_payd,
      total = up_total,
      statuspt = up_statuspt
  WHERE PhieuThueID = up_phieuthueid;
END;
$$

CALL update_phieuthue(10, 'John Doe', '123-456-7890', '2023-05-27', '2023-06-03', 100.00, 'Pending');

/* -------------------------- Delete PhieuThue ---------------------------- */
CREATE OR REPLACE PROCEDURE delete_phieuthue(phieuthue_id int)
LANGUAGE plpgsql
AS $$
BEGIN
  -- Check if the product exists
  IF NOT EXISTS (SELECT 1 FROM PhieuThue WHERE PhieuThueID = phieuthue_id) THEN
    RAISE EXCEPTION 'Product does not exist';
  END IF;

  -- Delete the product
  DELETE FROM PhieuThue WHERE PhieuThueID = phieuthue_id;

  -- Return success
  RETURN;
END;
$$













