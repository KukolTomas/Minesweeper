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

- Míra úspěchu
  - Důležitost - nízká
  - Po vyhrání hry se zobrazí statistika, která ukazuje, míru uspěchu dokončení hry v _%_
  ------------------------------------------
  
# 5. Nefunkční požadavky
------------------------------------------

## 5.1 Výkonnost
- Minimální požadavky pro hraní : 
  - OS : Windows 7/8/10 - 64 bit
  - Procesor : 2 GHz Intel Pentium 4 nebo ekvivalent
  - Paměť : 512 MB RAM
  - Grafická karta : Intel HD graphics
  - Pevný disk - 50 MB volného místa
------------------------------------------

## 5.2 Bezpečnost
- žádná autorizace
- žádná autentizace
- zádné cookies/ osobní údaje
- žádné mikrotransakce
------------------------------------------

## 5.3 Spolehlivost
- Program 1. z 10000 spuštění spadne s chybou
- 0,01 % šance na chybu
------------------------------------------

## 5.4 Projektová dokumentace
 <!---Zatím žádná není --> 



  
  






