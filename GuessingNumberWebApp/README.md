# Guessing Game Web Application

## Table of contents
- [Description](#Description)
- [Endpoints](#Endpoints)
- [Classes and Methods](#classes-and-methods)
- [How To Play](#how-to-play)

## Description
This web API allows you to play a number guessing game. The user specifies a range, and the server will attempt to guess the number by repeatedly dividing the range. The user responds with whether the guess is correct or not.

## Endpoints

### GuessingGameController
**POST /api/GuessingGame**
This endpoint processes the user's range and whether the server's guess was correct.

- Request body
  ```json
  {
    "from": 1,
    "to": 100,
    "success": false,
    "message": "" 
  }
  ```
- Response body
  - If the number is not guessed
    ```json
    {
      "from": 1,
      "to": 100,
      "answer": 50,
      "message": "Is 50 your number? If it is, send true in the success field, otherwise send false",
      "success": false
    }        
    ``` 
  - If the number is guessed
    ```json
    {
      "from": 1,
      "to": 100,
      "answer": 50,
      "message": "Is 50 your number? If it is, send true in the success field, otherwise send false",
      "success": false
    }
    ```
## How to Play
  - Start the game
    - Send a POST request to `/api/GuessingGame` with initial range.
    - For example: 
      ```json
      {
         "from": 1,
         "to": 100,
         "success": false,
         "message": ""
      }
      ```
  - Program Guesses
    - The server will respond with guess
    - For example: 
        ```json
      {
         "from": 1,
         "to": 100,
         "answer": 50,
         "message": "Is 50 your number? If it is, send true in the success field, otherwise send false",
         "success": false
      }
        ```
  - User responses
  - For example: 
      ```json
      {
         "from": 51,
         "to": 100,
         "success": false,
         "message": ""
      }
    ```
  - Repeat
    - Continue sending requests until the server guesses the correct number.
    - When the Correct number is guessed, set `success` field to true.
## Classes and Methods
###  Request Class

This class represents the user's request to the server.

#### Properties

- **int From:** The lower bound of the range.
- **int To:** The upper bound of the range.
- **bool Success:** Tells whether the guess is correct.
- **string Message:** An optional message from the user.

### Response Class

This class represents the server's response to the user.

#### Properties

- **int From:** The lower bound of the range.
- **int To:** The upper bound of the range.
- **int Answer:** The server's guess.
- **bool Success:** Tells whether the guess is correct.
- **string Message:** A message from the server.
