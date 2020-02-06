# System Specification - Folio

Folio is a website for users to buy and download e-books. Users have the option to search for an e-book using an author name or a title of a book. The homepage will present the user with various books that are randomly chosen. There will also be a browse page to look for a book via publisher, date of publication, author or genre.

Other pages that would be included within the website include the login and register pages where the user will be asked to enter their details to either register or login. Once this is completed, they can buy a book they would like which then gets added to the Order System for recording who has bought what. Folio consists of four systems that are allocated between four people. More details of each system are shown below under each subsection.

At the backend, we have access to the database so we will directly access data and do all the relevant actions such as addition, deletion, filtration and modification, listing and validation. A form will be designed to take in input for example for adding a new book entry.

Pre-defined SQL queries will be designed to instantly output relevant data for ease of use. For example, a query will be made to return all the users in the database or all books that are bought by a user. The result will return a list.

## User Management System

This system is run by Zana who will be creating the following functionality:

1. Front-end User Log-in. This includes validation.
2. Front-end User Sign-up. This includes validation.
3. Backend User addition, deletion, filtration and modification, listing and validation.
4. Front-end user sign up and login
5. Front-end user information update.

### User Schema

Below is the schema for a user. On the register page they would have to provide the following details.

1. First name
2. Last name
3. Date of birth
4. Email
5. Telephone number

Then these data will be sent to the server to be validated. An email also will be sent to the user to verify their information which is essential if they want to buy an e-book so that we know that they will receive an email for the receipt and the pdf of the desired book.

| Attribute              | Type (`datatype`)     | Key         |
| ---------------------- | --------------------- | ----------- |
| user_id                | String `varchar(25)`  | Private Key |
| user_firstName         | String `varchar(255)` |             |
| user_last_name         | String `varchar(255)` |             |
| user_dob               | Date `date`           |             |
| user_email             | String `varchar(255)` |             |
| user_tel               | String `varchar(13)`  |             |
| user_no_books_bought   | Integer `int`         |             |
| user_is_email_verified | Boolean `bit`         |             |

With every purchase, we will increment the `user_no_books_bought` field to keep record of how many books each individual has bought. This may come in handy to see how popular the website as a whole is.

When a user is authenticated through the front-end, the rest of the application is handled by the other systems.

## Book Management System

## Order & Record System
