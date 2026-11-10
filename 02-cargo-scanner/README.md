# Oppgave 02 — Cargo Scanner

**Hovedfokus:** comparison operators

En lasteskanner har målt en container. Oppgaven er å øve på sammenligningsoperatorer uten å gjemme logikken inne i mange `if`-setninger.

Lag bool-variabler som svarer på:
- Er lasten tyngre enn maksvekten?
- Er lasten nøyaktig lik maksvekten?
- Finnes det minst én container?
- Er antall containere forskjellig fra forventet antall?

Skriv alle bool-verdiene til terminalen.

Test minst med:
- `cargoWeight = 800`, `maxWeight = 800`
- `cargoWeight = 801`, `maxWeight = 800`
- `containerCount = 0`

## Kjøring

```bash
dotnet run
```
