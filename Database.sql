CREATE TABLE TheLoai (
  TheLoaiID int AUTO_INCREMENT,
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

INSERT INTO TheLoai (Name) VALUES
('Action'),
('Adventure'),
('Comedy'),
('Drama'),
('Family'),

INSERT INTO BangDia (BangDiaID, Name, TheLoaiID, Price, Quantity, Status)
VALUES
(1, 'The Book Thief', 1, 19.99, 10, 'In Stock'),
(2, 'To Kill a Mockingbird', 1, 17.99, 5, 'In Stock'),
(3, 'The Hunger Games', 2, 14.99, 20, 'In Stock'),
(4, 'Harry Potter and the Sorcerer''s Stone', 3, 12.99, 30, 'In Stock'),
(5, 'The Lord of the Rings: The Fellowship of the Ring', 4, 10.99, 40, 'In Stock');

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


CALL add_product('The Lord Dragon', 4, 13.99, 40, 'In Stock');

