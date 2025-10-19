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


> [!NOTE]
> Main
<br/><br/>
<img width="801" height="447" alt="image" src="https://github.com/user-attachments/assets/9f98a946-f445-47f4-bce8-e7c0597dd106" />

> [!NOTE]
> CreateInvoice
<br/><br/>
<img width="784" height="444" alt="image" src="https://github.com/user-attachments/assets/111b9360-e3d7-491d-8b50-d06e24ad9361" />

> [!NOTE]
> InvoiceCheck
<br/><br/>
<img width="791" height="436" alt="image" src="https://github.com/user-attachments/assets/8b9d8a7e-e9c5-42e5-abe6-9146b08b6265" />

> [!NOTE]
> InvoiceOpen
<br/><br/>
<img width="781" height="435" alt="image" src="https://github.com/user-attachments/assets/800857f6-4ed1-4df4-bfbc-009923fe634c" />
