--CREATE TABLE EMPLOYEE_MASTER(EMPLOYEE_ID VARCHAR(10) PRIMARY KEY, FIRST_NAME VARCHAR(50) NOT NULL, 
--							 LAST_NAME VARCHAR(50) NOT NULL, JOINING_DATE DATE NOT NULL,
--							 RELEASING_DATE DATE, DESIGNATION_ID VARCHAR(10) NOT NULL, SALARY INT NOT NULL,
--							 STATUS_ID VARCHAR(10) NOT NULL, CREATED_ON DATE DEFAULT GETDATE() NOT NULL, UPDATED_ON DATE)



--ALTER TABLE EMPLOYEE_MASTER ADD STATUS_ID BIT NOT NULL
--ALTER TABLE EMPLOYEE_MASTER ADD CONSTRAINT STATUS_ID_DEFAULT DEFAULT 1 FOR STATUS_ID
--ALTER TABLE EMPLOYEE_MASTER DROP CONSTRAINT STATUS_ID_DEFAULT 