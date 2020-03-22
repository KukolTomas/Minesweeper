# Minesweeper
- počítačová strategická hra
- verze 2.0
- autor : Tomáš Kukol

# 1.Úvod
------------------------------------------

## 1.1 Účel
- rozvoj logického myšlení 
- zabavení uživatele 
------------------------------------------

## 1.2 Pro koho je dokument určený
- určen pro všechny budou hráče a mě, jako autora
------------------------------------------

## 1.3 Kontakty
- email : kukol.tomas@gmail.com
- Adresa : Preslova 25, 150 21 Praha 5-Smíchov
- facebook : facebook.com/kukol.tomas
------------------------------------------
# 2. Celkový popis
- cílem hry je odkrýt všechny políčka,kde nejsou miny
- levý klik myši - odkrytí políčka
- pravý klik myši - položení vlaječky
- "P" - pauza hry

## 2.1 Produkt jako celek
![Návrh, jak by mohla vypadat hrací plocha](https://github.com/KukolTomas/Minesweeper/blob/master/minesweeper%20hrac%C3%AD%20plocha.png)


![Winning screen](https://github.com/KukolTomas/Minesweeper/blob/master/n%C4%9Bco%20jako%20winning%20screen.png)
------------------------------------------

## 2.2 Funkce
- odkrytí políčka
- položení vlaječky
- pauza hry
- start/konec hry
- nápověda
- tabulka nejrychlejších řešitelů
- výherní okno
- míra úspěchu
------------------------------------------

## 2.3 Uživatelské skupiny
- Hráč
------------------------------------------

## 2.4 Provozní prostředí
- uživatelovo lokální úložiště
------------------------------------------

## 2.5 Uživatelské prostředí
![Uživatelské prostředí](https://github.com/KukolTomas/Minesweeper/blob/master/minesweeper%20hrac%C3%AD%20plocha.png)

------------------------------------------

## 2.6 Omezení návrhu a implementace
- program nefunguje po síti
- hra nenabízí funkci více hráčů
- není implementována umělá inteligence
- žádné mikrotransakce
------------------------------------------

## 2.7 Předpoklady a závislosti
- Levý klik myši - odhalení políčka
- Pravý klik myši - položení vlaječky
- P - pauza hry
- Spuštění hry tlačítkem _Start hry_
- Zobrazení výherního okna - správné odkrytí všech políček
- Konec hry - Odhalení miny levým tlačítkem myši
------------------------------------------

# 3. Požadavky na rozhraní
------------------------------------------

## 3.1 Uživatelská rozhraní
- Windows
------------------------------------------

## 3.2 Hardwarová rozhraní
- myš
- klávesnice
- monitor
------------------------------------------

# 4. Vlastnosti systému
- Důležitost :
  - Vysoká
  - Střední
  - Nízká
 
- Vykreslení hracího pole
  - Důležitost - vysoká
  - Vykreslení hracího pole se zahájí kliknutím na tlačíko _Start hry_
  
- Položení vlaječky
  - Důležitost - střední
  - Vlaječka se položí pravým kliknutím myši na nevyužité políčko
  
- Časomíra
  - Důležitost - nízká
  - Od prvního kliknutí na hrací pole začne běžet časomíra. Časomíra se zastaví buď když uživatel prohraje a nebo když dokončí hru.
  
  






