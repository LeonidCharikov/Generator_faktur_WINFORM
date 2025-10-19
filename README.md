# Generator Faktur WINFORM VERZE
* Je to vylepšená verze původní [konzolové aplikace]([https://pages.github.com/](https://github.com/LeonidCharikov/Generator_Faktur)).
* Hlavní vylepšení že je to ted okenní aplikace vytvořená ve Visual Studio pomocí Windows Forms.
* Má základní grafické rozhraní
* Základ projektu je stejný. Ted ale program už neuklkádá automaticky soubor ISDOC do složky kde program běží, ale uživatel musí sám vybírat cestu ukládání pomocí otevření FileDialog.

## Okna
* ***Main***, kde lze vybrat bud otevřít soubor nebo vytvořit nový.
* ***CreateInvoice***, uživatel vkládá data pro vytvoření souboru.
* ***InvoiceCheck***, před vytvořením uživatel kontroluje data, zda jsou zadany správně. Pak to musí potvrdit a vybrat kam to uložit.
* ***InvoiceOpen***, uživatel může otevřit ISDOC soubor a podívát na základní data které uživatel zadal.


> [!CAUTION]
> POZOR PROGRAM NEFUNGUJE STEJNĚ JAKO STORMWARE PROTO NEMŮŽE OTEVŘÍT SOUBOR JAKO NORMÁLNÍ FAKTURU, JENOM XML DATA.



