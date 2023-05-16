CREATE DATABASE managerhotel

GO

USE managerhotel

GO

CREATE TABLE employees (
  employee_id int IDENTITY,
  employee_name varchar(255) DEFAULT NULL,
  gender varchar(6) DEFAULT NULL,
  email varchar(255) DEFAULT NULL,
  phone varchar(10) DEFAULT NULL,
  address varchar(255) DEFAULT NULL,
  role varchar(15) DEFAULT NULL,
  username VARCHAR(50) DEFAULT NULL,
  password varchar(45) DEFAULT NULL,
  PRIMARY KEY (employee_id)
)
GO
INSERT INTO employees (employee_name, gender, email, phone, address, role, username, password) 
VALUES ('Nguyen Thi Hong','Female','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Labor','labor01','123'),
('Tran Thi Nga','Female','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Labor','labor02','123'),
('Nguyen Trung Kien','Male','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Labor','labor03','123'),
('Van Vu Minh','Male','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Labor','labor04','123'),
('Nguyen Thi Binh','Female','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Labor','labor05','123'),
('Tran Tu Minh','Male','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Labor','labor06','123'),
('Tran Cong Anh','Female','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Receptionist','receptionist01','123'),
('Nguyen Minh Hoang','Male','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Receptionist','receptionist02','123'),
('Le Thai Chinh','Male','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Receptionist','receptionist03','123'),
('Tran Thi Thu','Female','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Receptionist','receptionist04','123'),
('Hoang Cong Duc','Male','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Manager','manager01','123'),
('Ly Tien Thanh','Male','nguyenminhquangquangquang@gmail.com','012344124','TPHCM','Manager','manager02','123')

GO
CREATE TABLE Timekeeping(
    Timekeeping_id INT IDENTITY,
    Timekeeping_employee int,
    date DATE,
    timein TIME,
    timeout TIME,
    PRIMARY KEY CLUSTERED (Timekeeping_employee,date)
);

GO

CREATE TABLE guests (
  guest_id int IDENTITY,
  guest_name varchar(255) DEFAULT NULL,
  guest_phone varchar(10) DEFAULT NULL,
  guest_gender varchar(6) DEFAULT NULL,
  guest_identity_card varchar(20) DEFAULT NULL,
  PRIMARY KEY (guest_id)
)

GO

CREATE TABLE rooms (
  room_id int IDENTITY,
  room_name varchar(45) DEFAULT NULL,
  room_type varchar(45) DEFAULT NULL,
  cost int DEFAULT NULL,
  status varchar(45) DEFAULT 'Empty'
  PRIMARY KEY (room_id)
)

GO

CREATE TABLE foods (
  food_id int IDENTITY,
  food_name varchar(255) DEFAULT NULL,
  cost int DEFAULT NULL,
  quantity INT DEFAULT NULL
  PRIMARY KEY (food_id)
)

GO

CREATE TABLE reservation (
  reservation_id int IDENTITY,
  employee_id int DEFAULT NULL,
  guest_id int DEFAULT NULL,
  room_id int DEFAULT NULL,
  date DATE DEFAULT NULL,
  timein TIME DEFAULT NULL,
  timeout TIME DEFAULT NULL,
  quantity int DEFAULT NULL,
  PRIMARY KEY (reservation_id)
)

GO

CREATE TABLE consumed_food (
  consumed_food_id int IDENTITY,
  reservation_id int DEFAULT NULL,
  food_id int DEFAULT NULL,
  quantity int DEFAULT NULL,
  PRIMARY KEY (consumed_food_id)
)

GO
CREATE TABLE food_in_room (
  food_in_room_id int IDENTITY,
  food_id int DEFAULT NULL,
  room_id int DEFAULT NULL,
  quantity int DEFAULT NULL,
  PRIMARY KEY (food_in_room_id)
)