# Eight #

This project is part of the 4 hour builds series

Concept Iteration 01

## Background : ##
I have an alarm set every day of the year for 8pm to make sure I am aware of what I am doing at 8pm; I once heard that you can tell a lot about a person by what they are doing at 8pm and that's stuck with me.

## Concept : ##
A system to log what I'm doing at 8pm each day along with categorization and report tools. 


## Implementation : ##

MVP : 

A blazor servor side application which logs specific criteria to a database 

Bonus Points : 

Google Calendar Integration

Criteria :

|MoSCoW|Name|DataType C#|DataType Sql|
|---|---|---|---|
|M|Date|DateTime|DateTime|
|M|Description|String|Nvarchar(MAX)|
|S|Day Rating|Decimal|Decimal(2, 2)|
|C|Activities Completed|Byte|TinyInt|

Bonus BONUS points: 

Make Activities completed a list of items with it's own table
