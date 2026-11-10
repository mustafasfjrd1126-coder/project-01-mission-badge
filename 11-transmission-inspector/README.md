# Oppgave 11 — Transmission Inspector

**Hovedfokus:** foreach over tegn i string

En radiosending inneholder `#` som markerer signalforstyrrelser.

Bruk `foreach` til å iterere gjennom **tegnene i en string** og tell hvor mange `#` som finnes.

Krav:
- Bruk `foreach`.
- Ikke bruk LINQ.
- Ikke bruk `string.Count(...)`.

Test med:
- `"AB#CD##EF"` → 3
- `"CLEAR"` → 0
- `"###"` → 3

## Kjøring

```bash
dotnet run
```
