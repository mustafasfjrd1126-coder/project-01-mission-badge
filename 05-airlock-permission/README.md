# Oppgave 05 — Airlock Permission

**Hovedfokus:** kombinerte logiske betingelser

En luftsluse kan bare åpnes når **alle** disse reglene er oppfylt:

- `hasSuit` er `true`
- `oxygenPercent` er minst `30`
- `pressure` er mellom `90` og `110`, inklusive
- `alarmActive` er `false`

Lag ett bool-uttrykk kalt `canOpenAirlock` og bruk deretter en `if/else` til å skrive `ACCESS GRANTED` eller `ACCESS DENIED`.

Endre én variabel om gangen for å kontrollere at hver regel faktisk påvirker resultatet.

## Kjøring

```bash
dotnet run
```
