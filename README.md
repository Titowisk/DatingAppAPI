# Some valuable Q&A during the course:

## About Authentication:
We use the HMAC key to generate the random salt here so we are salting and hashing the passwords.  The way we set up usernames and passwords here is just to help students understand the concepts of authentication - I wouldn't recommend rolling your own auth system in a real world app - in the bonus section we use ASP.NET Identity which would be preferable to using your own system.

## JWT: Jason Web Tokens

The server doesn't need to go back to the database to validate the user.

## Ctrl + Shift + P
Shortcut to Commands in Visual Studio Code

## Safe Storage of App Secrets
https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows