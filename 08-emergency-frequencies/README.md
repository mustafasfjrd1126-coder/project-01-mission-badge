# Oppgave 08 — Emergency Frequencies

**Hovedfokus:** flere case-labels med samme handling

Et nødpanel bruker signalene `RED`, `CRIMSON` og `SCARLET` for samme alarmtype.

Bruk en `switch` der flere `case`-labels deler samme kodeblokk.

Regler:
- `RED`, `CRIMSON`, `SCARLET` → `Evacuate deck`
- `AMBER`, `YELLOW` → `Prepare crew`
- `GREEN` → `No emergency`
- andre verdier → `Unknown signal`

Ikke dupliser samme `Console.WriteLine` tre ganger for de røde kodene.

## Kjøring

```bash
dotnet run
```
