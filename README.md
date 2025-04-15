
#  LINQ Queries - Backend Developer Task

This project was created as part of a job assignment to demonstrate proficiency with C#, LINQ queries, abstraction, and clean service structure.

## ℹ️ Note

This project is implemented as an **ASP.NET Core MVC application** to reflect a more real-world backend architecture.  
While a console application could have been used, this structure better demonstrates clean separation of concerns using:
- Controllers to call logic
- Services to contain LINQ queries
- An abstract base class for limiting service access
- Enums for product categories

All logic is visible in the service layer



## ✅ Task Requirements:

- Use LINQ to perform various operations on a static list of products
- Use `Enum` for product categories
- Keep LINQ logic inside a dedicated service
- Use a shared abstract class to limit the service implementation
- Write clear, readable code with explanations for each query

---

## 📦 Project Structure

- `Models/`
  - `Product.cs` – Product model
  - `Categories.cs` – Enum representing product categories

- `Services/`
  - `ProductServiceBase.cs` – Abstract base class
  - `ProductService.cs` – Implementation of all required LINQ queries

---

## 🧪 Implemented LINQ Queries:

1. **Filter Products by Category**
   - Returns all products from a specific category

2. **Get Most Expensive Product**
   - Finds the product with the highest price using `OrderByDescending(...).FirstOrDefault()`

3. **Total Price of All Products**
   - Sums all product prices using `.Sum(p => p.Price)`

4. **Group Products by Category**
   - Groups products using `.GroupBy(...).ToDictionary(...)`

5. **Get Average Price of Products**
   - Uses `.Average(p => p.Price)` to calculate mean price

Each method includes a brief explanation in the service file.


---

## 🧑‍💻 About the Author

This project was created as part of a backend job application.  
Feel free to contact me for any feedback or discussion!

---

> Thank you for reviewing my code! I look forward to the opportunity 🙌
