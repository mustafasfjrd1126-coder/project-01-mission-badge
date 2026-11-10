# Oppgave 06 — Scope Repair Lab

**Hovedfokus:** grunnleggende variable scope

Dette er en reparasjonsoppgave om scope.

En tidligere programmerer prøvde å deklarere `status` **inne i** hver gren og deretter skrive den ut etter `if`-blokken. Da er variabelen ute av scope.

Din oppgave:
1. Deklarer `status` på et sted der den kan brukes både inne i grenene og etterpå.
2. Sett den til `STRONG` når signalet er minst 70, ellers `WEAK`.
3. Skriv status etter `if/else`-blokken.

Den kommenterte koden viser formen på den opprinnelige feilen. Ikke bare flytt `Console.WriteLine` inn i hver gren; poenget er å gjøre verdien tilgjengelig etterpå.

## Kjøring

```bash
dotnet run
```
