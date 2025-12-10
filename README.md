# Shop'n'Go (Avalonia Rewrite)

A modern desktop E-commerce application built with **C#** and **Avalonia UI**.
This project is a complete rewrite/port of an existing React Native (Expo) mobile application, demonstrating how to share architecture between mobile and desktop environments.

## 🎯 Project Goal
To create a fully functional "Proof of Concept" (POC) desktop shop that replicates the features of the mobile version. It bridges the gap between a modern UI framework and cloud-native services.

## 🛠 Tech Stack

### Frontend (Desktop)
*   **Framework:** [Avalonia UI](https://avaloniaui.net/) (Cross-platform XAML)
*   **Language:** C# (.NET 10)
*   **Architecture:** MVVM (using CommunityToolkit.Mvvm)

### Backend & Services
*   **Database & Auth:** [Supabase](https://supabase.com/) (Direct client connection)
*   **Product Data:** [FakeStoreApi](https://fakestoreapi.com/) (REST)
*   **Payments:** [Stripe](https://stripe.com/)
*   **Custom API:** ASP.NET Core Web API (Acts as a secure middleware for Stripe transactions)

## 📂 Solution Structure

The solution follows a clean 3-tier architecture:

*   **`Shopngo.Client`**: The main Desktop application. Handles UI, State, and calls to Supabase/FakeStore.
*   **`Shopngo.Api`**: A lightweight backend acting as a secure gateway for payment processing (replacing Node.js).
*   **`Shopngo.Shared`**: Shared C# data models (DTOs) used by both the Client and API to ensure type safety.


## 🚀 Getting Started

1.  **Prerequisites:** .NET 10 SDK.
2.  **IDE:** JetBrains Rider (recommended) or Visual Studio.
3.  **Setup:**
    *   Clone the repository.
    *   Run `dotnet restore`.
    *   Use the "**`Run All`**" configuration to launch both the API and the Client simultaneously.  
        