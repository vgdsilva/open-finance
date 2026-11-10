# Open Finance

> Open source, self-hosted personal finance. Your data, your server.

**Open Finance** is a personal finance manager you download and run on your own computer or server. It focuses on the financial life of individuals and families, with administrative management features for those who need a bit more organization.

> ⚠️ **Status:** planning stage. No usable release yet.

---

## 🎯 Vision

- **Privacy first:** no data leaves your machine. No mandatory cloud, no tracking.
- **Truly self-hosted:** simple installation, designed so anyone can get it running with a few commands.
- **Personal, but shareable:** each user has their own view, and dashboards can be shared with whoever you want (partners, family, business partners).
- **Free and open:** open, auditable code, open to contributions.

## ✨ Planned features

### Configurable dashboard
- A home dashboard built by each user, with widgets that can be added, removed and rearranged.

### Bank accounts and credit cards
- Bank accounts (checking, savings, investment, cash wallet).
- Credit cards linked to a bank account, with limit, closing date, due date and statements.
- Installment purchases on credit cards.

### Bills and income management
- **Fixed amounts:** rent, tuition, salary.
- **Variable amounts:** bills that change every month, such as electricity, water and groceries.
- **Subscriptions:** recurring services with renewal tracking.
- **Future bills:** forecasting and scheduling of upcoming payments.

### Cash flow
- **Personal** or **shared** cash flow dashboards between users.
- Actual vs. forecast view by period.

### Virtual assistant
- An assistant to check balances, record transactions and answer questions about your finances in natural language.

### Administrative management
- Users, permissions and sharing groups.
- Categories, cost centers and reports.

## 🛠️ Stack

| Layer | Technology |
|---|---|
| Language | C# (.NET) |
| Database | PostgreSQL |
| Distribution | Docker / Docker Compose *(planned)* |

> The front-end framework, architecture and folder structure will be documented as the project evolves.

## 🚀 Running it (self-hosting)

*Coming soon.* The goal is to bring everything up with something like:

```bash
git clone https://github.com/<user>/open-finance.git
cd open-finance
docker compose up -d
```

## 🗺️ Roadmap

- [ ] Initial .NET solution structure
- [ ] Database modeling
- [ ] Authentication and users
- [ ] Bank accounts and credit cards
- [ ] Bills and income (fixed, variable, subscriptions, future)
- [ ] Personal and shared cash flow
- [ ] Configurable dashboard
- [ ] Virtual assistant
- [ ] Self-hosting packaging

## 🤝 Contributing

Contributions are welcome! A contributing guide (`CONTRIBUTING.md`) will be added soon. Until then, open an *issue* to suggest ideas or report problems.

## 📄 License

To be defined (suggestion: [AGPL-3.0](https://www.gnu.org/licenses/agpl-3.0.html) or [MIT](https://opensource.org/licenses/MIT)).
