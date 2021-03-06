# 1. Úvod - Funkční specifikace
- autor : Tomáš Kukol
- verze : 1.0
- datum vytvoření : 03/04/2020

------------------------------------------

## 1.1 Účel
- Dokument, který popisuje chování hry z hlediska uživatele

------------------------------------------

## 1.2 Konvence dokumentu


------------------------------------------

## 1.3 Pro koho je dokument určený
- Dokument je určený pro členy týmu, viz. pro vývojaře, testery

------------------------------------------

## 1.4 Odkazy na ostatní dokumenty
[Link na SRS](https://github.com/KukolTomas/Minesweeper/blob/master/README.md)

------------------------------------------

# 2 Scénáře

------------------------------------------

## 2.1 Všechny reálné způsoby využití
- Jediné reálně využití je hraní

------------------------------------------

## 2.2 Typy uživatelský rolí, "personas"
- Pouze hráči

------------------------------------------

## 2.3 Detaily, motivace, "živé" příklady
 - ![Návrh, jak by mohla vypadat hrací plocha](https://github.com/KukolTomas/Minesweeper/blob/master/minesweeper%20hrac%C3%AD%20plocha.png )
- ![Winning screen](https://github.com/KukolTomas/Minesweeper/blob/master/n%C4%9Bco%20jako%20winning%20screen.png)
------------------------------------------

## 2.4 Vymezení rozsahu - co v sw nebude
- Umělá inteligence
- Hraní po síti
- Možnost multiplayeru
- Mikrotransakce
- Reklamy
- žádná autentizace a autorizace
- sbírání dat
------------------------------------------

## 2.5 Na so se nebude klást důraz
- Na výkonnost, hra nebude náročná
- Na bezpečnost - hra neběží po síti -> žádná autentizace a autorizace - > proto se nebude klást důraz na bezpečnost
------------------------------------------

# 3. Celková hrubá architektura

------------------------------------------

## 3.1 Pracovní tok
- idea
- vývoj
- testování
- release
------------------------------------------

## 3.2 Hlavní moduly

------------------------------------------

## 3.3 Všechny detaily : obrazovky, okna, tisky, chybové zprávy, logování
- Návrh hrací plochy

 - ![Návrh, jak by mohla vypadat hrací plocha](https://github.com/KukolTomas/Minesweeper/blob/master/minesweeper%20hrac%C3%AD%20plocha.png )
 
 - Návrh výherního okna
- ![Winning screen](https://github.com/KukolTomas/Minesweeper/blob/master/n%C4%9Bco%20jako%20winning%20screen.png)

- Návrh okna, kdy uživatel prohraje
- ![Losing screen](https://github.com/KukolTomas/Minesweeper/blob/master/minesweeperLose.png "Test")

------------------------------------------

## 3.4 Všechny možné toky programu a jejich projevy
- nerozumím tomu, co je tím myšleno
------------------------------------------

## 3.5 Všechny dohodnuté principy
- Levý klik myši - odhalení políčka
- Pravý klik myši - položení vlaječky
- P - pauza hry
- Spuštění hry tlačítkem _Start hry_
- Zobrazení výherního okna - správné odkrytí všech políček
- Konec hry - Odhalení miny levým tlačítkem myši
------------------------------------------

# 4. Otevřené otázky

------------------------------------------

## 4.1 Části, na kterých se zatím nedosáhlo shody 

------------------------------------------

## 4.2 Poznámky pro realizaci

------------------------------------------



