# System Specification - Folio

Folio is a website for users to buy and download e-books. Users have the option to search for an e-book using an author name or a title of a book. The homepage will present the user with various books that are randomly chosen. There will also be a browse page to look for a book via publisher, date of publication, author or genre.

Other pages that would be included within the website include the login and register pages where the user will be asked to enter their details to either register or login. Once this is completed, they can buy a book they would like which then gets added to the Order System for recording who has bought what. More details of each area are shown below under each subsection.

Folio consists of four systems that allocated between four people. These system are:

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
| user_tel               | Integer `bigint`      |             |
| user_is_email_verified | Boolean `bit`         |             |

For the telephone number attribute, we thought that it would be best to have the data type as a `bigint` rather than a `varchar` as each character of a varchar is a byte where as `bigint` is only 8 bytes for 20 digits; this will be cut down to a max of 12 digits.

It will look something like this.

```
447712345678
^^ country code
```

When a user is authenticated through the front-end, the rest of the application is handled by the other systems.

## Book Management System

## Order & Record System
