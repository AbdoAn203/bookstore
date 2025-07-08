# Bookstore Console Application

A simple C# console application for managing a bookstore inventory, supporting paper books, ebooks, and demo books. The system allows adding, removing, and purchasing books, with basic shipping and email services.

## Features

- **Book Types**: Supports PaperBook, Ebook, and Demo (not for sale).
- **Inventory Management**: Add, remove (by age), and list books.
- **Purchase Flow**:
  - PaperBook: Checks stock, supports shipping.
  - Ebook: Sends via email.
  - Demo: Not for sale.
- **Validation**: Input validation for book details.
- **Services**: Shipping and Mail services for order fulfillment.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Build and Run

1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Set `bookstore` as the startup project.
4. Build and run (`F5` or `Ctrl+F5`).

### Example Usage

The `Program.cs` demonstrates:

- Adding books to inventory.
- Removing outdated books (20+ years old).
- Purchasing books (with stock and sale checks).
- Handling unavailable or demo books.

## Demo Screenshots

Below is the full demo screenshot for this program:
![Demo] (https://github.com/AbdoAn203/bookstore/blob/master/bookstore/bookstore/Demo/FullDemo.PNG)



## Project Structure

- `Books/` - Book, PaperBook, Ebook, Demo classes.
- `Inventorys/` - Inventory management.
- `Services/` - Shipping and Mail services.
- `Program.cs` - Main entry point and usage demo.
