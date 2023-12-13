# Text-Em-All Back End Coding Challenge Solution

Hello TEA development team! Thank you for taking the time to review my solution to your coding challenge. I had a lot of fun working on it and I hope you enjoy reviewing it. I look forward to hearing from you soon!

The original challenge link can be found [here](https://github.com/callemall/tea-c-sharp-challenge/).

## Project Notes

### General

- **.NET 7.0.14** was used for this project. [.NET 8.0 is now available](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) but doesn't meet the requirements of the challenge.
- The solution was built using [Jetbrains Rider](https://www.jetbrains.com/rider/).

### Challenge 1

- Database models in the **TEAChallenge.Data** project were generated (then manually cleaned up) using the following command: `dotnet ef dbcontext scaffold "<CONNECTION_STRING>" Microsoft.EntityFrameworkCore.SqlServer -o Models`
- The original sql script to create the database and tables can be found here: [create_tea_test_db.sql](TEAChallenge.Data/create_tea_test_db.sql)
- The database connection string is stored in local user secrets and is not included in `appSettings.json`

### Challenge 2

- Challenge2 can be found in the **TEAChallenge.Challenges** project and can be tested by running the unit test in the **TEAChallenge.Tests** project.
- Challenge2 will only reliably work with strings comprised of lower case letters. Additional character support would require more specific `MaxDistance()` output expectations.
