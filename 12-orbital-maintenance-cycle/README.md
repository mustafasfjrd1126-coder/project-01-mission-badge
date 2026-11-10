# Oppgave 12 — Orbital Maintenance Cycle

**Hovedfokus:** løkke + divisibilitetsregler

Et vedlikeholdssystem kjører 30 omløpssykluser. For hver syklus skal ett av disse resultatene skrives:

- delelig med både 4 og 6 → `FULL SERVICE`
- ellers delelig med 4 → `FILTER CHECK`
- ellers delelig med 6 → `THRUSTER CHECK`
- ellers → selve syklusnummeret

Krav:
- Bruk én løkke fra 1 til 30.
- Bruk `%` for divisibilitet.
- Sjekk den mest spesifikke regelen først.

Dette er en oppgave på samme resonneringsnivå som FizzBuzz, men med et annet domene.

## Kjøring

```bash
dotnet run
```
