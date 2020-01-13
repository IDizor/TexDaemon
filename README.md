# TexDaemon

The tool to process huge number of files using predefined set of rules based on Regex and combined with Javascript logic.
Windows Desktop Application.

GETTING STARTED

1. Search for files or specify files manually in text field "Search results";
2. You can apply any regex to files list (e.g. change files extension);
3. Populate grid below with files processing rules. Each row is a separate rule.
4. Click "Process files" button.

Grid columns:
- Condition RegEx: means apply this rule if file matches this regex.
- RegEx: common regex match to select data you going to change.
- Substitution: common regex substitution, javascript logic can be applied here as well.

Example:
We are going to add $1000 to price for CDs if year is 1990 or more.
We have catalog XML file "C:\Example.xml" with content:

<?xml version="1.0" encoding="UTF-8"?>
<CATALOG>
  <CD>
    <TITLE>Greatest Hits</TITLE>
    <ARTIST>Dolly Parton</ARTIST>
    <PRICE>9.90</PRICE>
    <YEAR>1982</YEAR>
  </CD>
  <CD>
    <TITLE>Still got the blues</TITLE>
    <ARTIST>Gary Moore</ARTIST>
    <PRICE>10.20</PRICE>
    <YEAR>1990</YEAR>
  </CD>
  <CD>
    <TITLE>Eros</TITLE>
    <ARTIST>Eros Ramazzotti</ARTIST>
    <PRICE>9.90</PRICE>
    <YEAR>1997</YEAR>
  </CD>
</CATALOG>

Lets make rule:
Condition RegEx (just check if this is catalog storage xml) : ^<.+?>\s*<CATALOG>
RegEx: <PRICE>([\d\.]+)</PRICE>  <YEAR>(\d+)</YEAR>
Substitution: #js#[$2>=1990?$1+1000:$1,$2]

Done. #js# means that program should run this substitution in JS engine. If JS result is an array then each regex captured group will be replaced with corresponding array element. Order is important. In case JS result is not an array then the whole matched text will be replaced with JS result.
