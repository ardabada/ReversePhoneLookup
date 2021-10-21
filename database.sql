CREATE SEQUENCE operator_id_seq;
CREATE SEQUENCE phone_id_seq;
CREATE SEQUENCE contact_id_seq;

CREATE TABLE operator(
	id INTEGER NOT NULL DEFAULT nextval('operator_id_seq'),
	mcc CHARACTER VARYING(3) NOT NULL,
	mnc CHARACTER VARYING(2) NOT NULL,
	name CHARACTER VARYING(25) NOT NULL,
	CONSTRAINT operator_pkey PRIMARY KEY(id)
);

CREATE TABLE phone(
	id INTEGER NOT NULL DEFAULT nextval('phone_id_seq'),
	value CHARACTER VARYING(25) NOT NULL,
	operator_id INTEGER,
	CONSTRAINT phone_pkey PRIMARY KEY(id),
	CONSTRAINT phone_operator_id_fkey FOREIGN KEY(operator_id)
		REFERENCES operator(id) ON UPDATE CASCADE ON DELETE SET NULL
);

CREATE TABLE contact(
	id INTEGER NOT NULL DEFAULT nextval('contact_id_seq'),
	phone_id INTEGER NOT NULL,
	name CHARACTER VARYING(50) NOT NULL,
	CONSTRAINT contact_pkey PRIMARY KEY(id),
	CONSTRAINT contact_phone_id_fkey FOREIGN KEY(phone_id)
		REFERENCES phone(id) ON UPDATE CASCADE ON DELETE CASCADE
);

INSERT INTO operator(mcc, mnc, name) VALUES('259', '01', 'Orange'),('259', '02', 'Moldcell'),('259', '03', 'Unite');
INSERT INTO phone(value, operator_id) VALUES('+37369123456', 1), ('+37378123456', 2);
INSERT INTO contact(phone_id, name) VALUES(1, 'Ivan Petrov'),(1, 'Ivan Programist'),(2, 'Pizza Delivery');