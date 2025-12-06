# Generator Faktur WINFORM VERZE
* Je to vylepšená verze původní [konzolové aplikace](https://github.com/LeonidCharikov/Generator_Faktur).
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


> [!NOTE]
> Main
<br/><br/>
<img width="810" height="484" alt="image" src="https://github.com/user-attachments/assets/abcc92d5-4939-4291-8a2d-dc2f78f35a15" />

> [!NOTE]
> CreateInvoice
<br/><br/>
<img width="809" height="481" alt="image" src="https://github.com/user-attachments/assets/93cfe97a-c450-4811-b825-874342691589" />


> [!NOTE]
> InvoiceCheck
<br/><br/>
<img width="810" height="484" alt="image" src="https://github.com/user-attachments/assets/8eec0a26-59a0-4e22-bf81-92ffa0715738" />


> [!NOTE]
> InvoiceOpen
<br/><br/>
<img width="809" height="484" alt="image" src="https://github.com/user-attachments/assets/7e68d218-433b-4f1d-805c-cb595b36de7f" />

