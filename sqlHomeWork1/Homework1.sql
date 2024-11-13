CREATE DATABASE HomeWork1DB

USE HomeWork1DB

CREATE TABLE regions (
    region_id INT PRIMARY KEY IDENTITY,
    region_name VARCHAR(25)
);

CREATE TABLE countries (
    country_id CHAR(2) PRIMARY KEY,
    country_name VARCHAR(40),
    region_id INT,
    FOREIGN KEY (region_id) REFERENCES regions(region_id)
);


CREATE TABLE locations (
    location_id INT PRIMARY KEY IDENTITY,
    street_address VARCHAR(25),
    postal_code VARCHAR(12),
    city VARCHAR(30),
    state_province VARCHAR(25),
    country_id CHAR(2),
    FOREIGN KEY (country_id) REFERENCES countries(country_id)
);


CREATE TABLE departments (
    department_id INT PRIMARY KEY IDENTITY,
    department_name VARCHAR(30),
    manager_id INT,
    location_id INT,
    FOREIGN KEY (location_id) REFERENCES locations(location_id)
);


CREATE TABLE jobs (
    job_id VARCHAR(10) PRIMARY KEY,
    job_title VARCHAR(35),
    min_salary DECIMAL(10, 2),
    max_salary DECIMAL(10, 2)
);


CREATE TABLE employees (
    employee_id INT PRIMARY KEY IDENTITY,
    first_name VARCHAR(20),
    last_name VARCHAR(25),
    email VARCHAR(25),
    phone_number VARCHAR(20),
    hire_date DATE,
    job_id VARCHAR(10),
    salary DECIMAL(10, 2),
    commission_pct DECIMAL(5, 2),
    manager_id INT,
    department_id INT,
    FOREIGN KEY (job_id) REFERENCES jobs(job_id),
    FOREIGN KEY (manager_id) REFERENCES employees(employee_id),
    FOREIGN KEY (department_id) REFERENCES departments(department_id)
);


CREATE TABLE job_history (
    employee_id INT IDENTITY,
    start_date DATE,
    end_date DATE,
    job_id VARCHAR(10),
    department_id INT,
    PRIMARY KEY (employee_id, start_date),
    FOREIGN KEY (employee_id) REFERENCES employees(employee_id),
    FOREIGN KEY (job_id) REFERENCES jobs(job_id),
    FOREIGN KEY (department_id) REFERENCES departments(department_id)
);


CREATE TABLE job_grades (
    grade_level VARCHAR(3) PRIMARY KEY,
    lowest_sal DECIMAL(10, 2),
    highest_sal DECIMAL(10, 2)
);
