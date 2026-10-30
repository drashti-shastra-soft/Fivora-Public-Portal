# Fivora

Fivora is a responsive ASP.NET public portal for investments and insurance. Visitors can explore mutual funds, SIPs, and life, health, and motor insurance, use SIP and premium calculators, read guides and blogs, and request a free consultation. The site is SEO-friendly, mobile-ready, and managed through an easy admin panel.

## Features

- **Public landing pages** — home, about, services, and contact pages with a clean, responsive layout.
- **Investments** — mutual fund listings, categories, and detail pages; SIP information and onboarding guidance.
- **Insurance** — life, health, and motor insurance product pages with coverage highlights and eligibility notes.
- **SIP calculator** — client-side calculator for estimating SIP returns based on monthly investment, tenure, and expected rate.
- **Premium calculator** — client-side calculator for estimating insurance premiums based on product type and inputs.
- **Guides & blogs** — list and detail pages for articles, guides, and educational content.
- **Free consultation form** — lead capture form with validation; submissions stored and viewable in the admin panel.
- **SEO-friendly** — clean URLs, meta titles/descriptions, canonical tags, Open Graph tags, sitemap, and `robots.txt`.
- **Mobile-ready** — Bootstrap-based responsive layout for mobile, tablet, and desktop.
- **Admin panel** — manage pages, products, guides/blogs, consultation leads, and site settings.
- **Shared web UI** — Razor views, shared layout, partials, pagination helper, and client-side validation.

> Feature descriptions are based on the controllers, domain models, services, and views present in this repository. Actual behavior may depend on the connected database and configuration.

## Technology stack

- C# and .NET Framework 4.8 (or `<your target framework>`)
- ASP.NET MVC with Razor views
- Bootstrap 5 for responsive UI
- HTML, CSS, JavaScript, and jQuery
- Visual Studio solution (`Fivora.sln`)
- Entity Framework + SQL Server for content and lead storage
- SEO tooling: meta tags, sitemap, and `robots.txt`

## Solution structure

```text
V4/
├── Fivora.sln
├── Fivora/                                # ASP.NET MVC public portal
│   ├── Controllers/                       # Public + admin controllers
│   ├── Views/                             # Razor UI pages
│   │   ├── Shared/                        # Layout and partials
│   │   ├── Home/                          # Landing pages
│   │   ├── Investments/                   # Mutual funds and SIP pages
│   │   ├── Insurance/                     # Life, health, motor pages
│   │   ├── Calculators/                   # SIP and premium calculators
│   │   ├── Guides/                        # Guides and blogs
│   │   └── Admin/                         # Admin panel views
│   ├── Content/                           # CSS, JS, images, fonts
│   ├── App_Start/                         # Routes, filters, DI setup
│   ├── Config/                            # Environment-specific app settings
│   └── Web.config
