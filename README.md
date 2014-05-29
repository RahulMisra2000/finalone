finalone
========
This contains the NorthWind processing....




What WebApplication2 contains:
==============================
look at it to see how we can programmatially do CRUD against the ASP.NET Identity database.
Also, it contains code that shows how to create a table (ToDo) that will have a 1:M relationship with the user table in the Identity
database. Basically, using the dbcontext of the identity database for our classes/tables as well. This way the user information
is integrated.

Also, if a certain user creates a todo record then only that user should be able to view it.

