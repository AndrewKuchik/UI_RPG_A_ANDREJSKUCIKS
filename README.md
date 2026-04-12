# UI_RPG_A_ANDREJSKUCIKS


Stundas laikā tika izveidota pamata spēles struktūra:

 Character klase ar veselību , vārdu un pamata metodēm Attack un TakeDamage
 Player un Enemy klases, kas manto no Character
GameManager, kas kontrolē spēles loģiku
 Spēlētājs uzbrūk, ienaidnieks uzbrūk atpakaļ
 UI elementi, kas attēlo veselību un vārdus




Pēc stundas es papildināju projektu ar funkcijām:

 1Ienaidnieku nāve un spawn sistēma

Kad ienaidnieks nomirst, tas tiek iznīcināts un tiek izveidots jauns ienaidnieks.

2 Game Over sistēma

Ja spēlētājs zaudē visu veselību, spēle beidzas.
Projektā es izmantoju enkapsulāciju, lai kontrolētu piekļuvi datiem.

Veselība tiek glabāta kā private mainīgais, un piekļuve tai notiek caur getter un setter. Setter nodrošina, ka veselība nevar nokrist zem 0.


3 Ieroču sistēma abstrakcija un polimorfisms

Es izveidoju abstraktu Weapon klasi ar metodēm:

 GetDamage()
ApplyEffect()

No šīs klases manto vairāki ieroči:

Blade pamata ierocis ar nejaušu bojājumu
 PoisonBlade nodara papildu poison bojājumu
 IceBlade sasaldē ienaidnieku, un viņš izlaiž vienu gājienu

Sākumā man bija problēma ar IceBlade, jo ienaidnieks joprojām uzbruka. Es sapratu, ka pārbaude jāveic pirms uzbrukuma, nevis pēc, un to izlaboju.


4 Burvestību sistēma (spells / buffs)

Es pievienoju heal burvestību, kas ļauj spēlētājam atjaunot veselību.

Tā tiek aktivizēta ar UI pogu un izmanto Character klases metodi Heal().



 5 Dažādi ienaidnieku tipi

Es izveidoju 3 dažādus ienaidniekus ar atšķirīgiem parametriem:

Fast Enemy maz veselības, bet liels bojājums
Tank Enemy liela veselība, bet mazs bojājums
Basic Enemy 
Ienaidnieki tiek izvēlēti nejauši (random) katru reizi, kad iepriekšējais nomirst.



6 Shield sistēma spēlētājs var ieslēgt/izslēgt vairogu, kas samazina saņemto bojājumu


Vizuālie un audio uzlabojumi


galvenais varonis
trīs dažādi ienaidnieki
spēles fons

Kad ienaidnieks vai spēlētājs saņem bojājumus scale palielināšana un atgriešana


Spēlei arī pievienoju fona mūziku

