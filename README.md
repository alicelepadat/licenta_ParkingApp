# easypark - aplicație DEMO de parcare București 

## Link
https://licenta-parking-app.vercel.app/

Va puteti autentifica prin înregistrarea unui cont nou (parolele sunt criptate).

# Descriere

Aplicația dezvoltată este o aplicație web progresivă și are ca principal obiectiv facilitarea parcării autoturismelor în zonele de utilitate publică generală din București, precum și gestionarea acestora de către administrația publică.

Aplicația de parcare se adresează atât șoferilor, cât și entităților administrative din București. Acestea din urmă au două tipuri de utilizator: administrator și admin, astfel încât administratorul gestionează totalitatea zonelor de parcare, iar admin-ul este responsabil de o singură zonă de parcare. Șoferul poate utiliza aplicația anonim sau se poate autentifica sau înregistra un cont nou.

## Funcționalități:

Principalele funcționalități ale aplicației sunt:

Sofer | Administrator | Admin
| :--- | :--- | :---
localizare utilizator | localizare utilizator | localizare utilizator
creare cont sofer | creare cont admin |
adaugare permis de conducere |  |
editare profil | editare parola | editare parola
verifica disponibilitate zona de parcare
rezerva loc de parcare
efectueaza plata tarif de parcare  |  |
anuleaza/sterge rezervare |  | anuleaza/sterge rezervare
filtreaza rezervari | filtreaza rezervari | filtreaza rezervari
|  | genereaza rapoarte rezervari |
|  | descarca/printeaza rapoarte rezervari |

## Tehnologii folosite

Modulul server constituie un web API și este construit în totalitate cu framework-ul ASP.NET.

Modulul client este construit cu biblioteca JavaScript, React, alături de Redux pentru o gestionarea eficientă a stării componentelor.

Ambele module comunică cu API-ul Stripe în vederea integrării facilității de plată în aplicație. Modulul client comunică cu API-ul Mapbox care asigură afișarea unei hărți interactive.

Datele persistă într-o bază de date relațională SQL Server stocată în cloud (AWS).

Aplicația server este hostată în Azure App Service, iar aplicația client în Vercel.

## Interfața aplicației

* Ecranul de pornire:

![image](https://user-images.githubusercontent.com/62174074/128016743-1f4baaf0-c858-4133-a7bb-d8c28fcb642d.png)

* Rezervări:

![image](https://user-images.githubusercontent.com/62174074/128017301-91ecd051-a6d9-49e3-b30c-f386f2b5fc55.png)

* Vehicule:

![image](https://user-images.githubusercontent.com/62174074/128017590-21180f13-0723-4706-85aa-c2333bcd039e.png)

* Profil șofer:

![image](https://user-images.githubusercontent.com/62174074/128017641-d4902d46-81f6-4a0d-b1c4-9cb0a35db787.png)

* Panou administrator:

![image](https://user-images.githubusercontent.com/62174074/128018064-29c0dcab-a514-4ca8-bc7b-54e3918d5355.png)

* Rapoarte:

![image](https://user-images.githubusercontent.com/62174074/128018151-59163199-2c8b-4000-8d71-7cfee997c9de.png)

* Panou admin:

![image](https://user-images.githubusercontent.com/62174074/128017933-f8199c68-da27-41ae-8408-eeaa6b979f6d.png)

