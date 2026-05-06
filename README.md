# CalcSharp 🧮

A clean, minimal WPF Calculator built with C# and .NET 8, featuring a full CI/CD pipeline with GitHub Actions.

![CI](https://github.com/benrisma133/CalcSharp/actions/workflows/ci.yml/badge.svg)

---

## ✨ Features

- Basic arithmetic operations — Addition, Subtraction, Multiplication, Division
- Percentage and negate support
- Divide by zero protection
- Clean dark UI
- Automated build and test pipeline with GitHub Actions

---

## 🛠 Tech Stack

| Technology | Purpose |
|------------|---------|
| C# / .NET 8 | Core language |
| WPF | Desktop UI framework |
| xUnit | Unit testing |
| GitHub Actions | CI/CD pipeline |

---

## 📁 Project Structure

```

CalcSharp/
├── .github/
│   └── workflows/
│       └── ci.yml        ← CI/CD pipeline
├── CalcSharp/            ← WPF UI
│   ├── MainWindow.xaml
│   └── MainWindow.xaml.cs
├── CalcSharp.Tests/      ← xUnit tests
│   └── CalculatorTests.cs
└── CalcSharp.slnx

```


---

## ⚙️ CI/CD Pipeline

Every push to `main` automatically:

1. ✅ Builds the project
2. ✅ Runs all xUnit tests
3. ✅ Publishes a standalone `.exe`
4. ✅ Uploads it as a downloadable artifact

---

## 🧪 Tests

| Test | Description |
|------|-------------|
| `Add_TwoNumbers_ReturnsCorrectResult` | 2 + 3 = 5 |
| `Subtract_TwoNumbers_ReturnsCorrectResult` | 10 - 4 = 6 |
| `Multiply_TwoNumbers_ReturnsCorrectResult` | 3 × 4 = 12 |
| `Divide_TwoNumbers_ReturnsCorrectResult` | 10 ÷ 2 = 5 |
| `Divide_ByZero_ReturnsNaN` | 10 ÷ 0 = Infinity |

---

## 🚀 How to Run

1. Clone the repository
```bash
   git clone https://github.com/benrisma133/CalcSharp.git
```
2. Open `CalcSharp.slnx` in Visual Studio 2022
3. Press `F5` to run

---

## 📦 Download

Go to [Actions](https://github.com/benrisma133/CalcSharp/actions) → latest run → **Artifacts** → download `CalcSharp-win-x64.zip`

---

## 👨‍💻 Author

**Ismail** — [@benrisma133](https://github.com/benrisma133)