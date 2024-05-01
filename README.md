# Event-Driven Bank Account Management System

This script provides a simple event-driven approach to manage bank accounts, including functionalities like creating an account, depositing money, withdrawing money, and checking balance. It utilizes the concept of event handling and polymorphism to demonstrate a flexible and extensible design.

## Features

- **Create Account**: Allows users to create a bank account by providing customer information.
- **Deposit Money**: Enables users to deposit money into their bank account.
- **Withdraw Money**: Allows users to withdraw money from their bank account.
- **Check Balance**: Provides functionality to check the current balance of the bank account.
- **Event Handling**: Utilizes events to trigger actions upon completion of each banking operation.
- **Polymorphism**: Demonstrates polymorphic behavior by using different message services for notifying users about account operations.

## How to Use

1. **Compile and Run**: Compile the script and execute the compiled program to interact with the bank account management system.
2. **Select Options**: Follow the on-screen prompts to select the desired operation from the menu.
3. **Provide Information**: Depending on the selected operation, provide the required information such as customer details, deposit/withdraw amount, etc.
4. **Receive Notifications**: Upon completion of each operation, the user will receive notifications via SMS, email, and Telegram.

## Code Structure

- **Program.cs**: Main entry point of the application containing the `Main` method.
- **MenuManagement.cs**: Handles the display of the menu and user input.
- **AccountOperation.cs**: Manages the operations related to bank accounts, including event handling for various account actions.
- **DataManagement.cs**: Provides methods to retrieve customer information.
- **AccountEventArgs.cs**: Defines the event arguments for account-related events.
- **IMessageService.cs**: Defines the interface for message services.
- **SmsService.cs, MailService.cs, TelegramService.cs**: Implementations of message services for sending notifications.


## Author

- Nurana Zeynalli - https://github.com/Znurana?tab=repositories
