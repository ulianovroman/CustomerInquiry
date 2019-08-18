INSERT INTO dbo.Customers 
(Id, Name, Email, Mobile)
VALUES 
(123456, 'Firstname Lastname', 'user@domain.com', '0123456789'),
(1234567, 'Customer With Transaction', 'email1@domain.com', '0987654321'),
(12345678, 'With Multiple Transactions', 'email2@domain.com', '1357924680')

INSERT INTO dbo.Transactions
(Id, Date, Amount, Currency, Status, CustomerId)
VALUES
(1, '20180618 10:34:09 AM', 240.45, 'USD', 10, 1234567),
(2, '20180717 11:30:00 AM', 20.17, 'EUR', 10, 12345678),
(3, '20190519 09:34:09 AM', 3000.00, 'RUB', 10, 12345678),
(4, '20180620 08:34:09 AM', 1234.17, 'THB', 20, 12345678),
(5, '20180122 07:34:09 AM', 87.17, 'USD', 30, 12345678)