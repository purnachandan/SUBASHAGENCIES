USE SUBASHAGENCIES

CREATE TABLE BEAT_MASTER(BEAT_ID VARCHAR(10) PRIMARY KEY,
						BEAT_NAME VARCHAR(200) NOT NULL,
						OUTLET_COUNT INT NOT NULL DEFAULT 0,
						CREATED_ON DATE NOT NULL DEFAULT GETDATE(),
						UPDATED_ON DATE)

--DROP TABLE BEAT_MASTER