# Dungeon-Delve

Per entendre el funcionament d'aquest projecte, primer introduiré uns quants conceptes i una petita presentació.

## Índex

- [Creador](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#creador)
- [De què tracta](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#de-què-tracta)
- [Història](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#història)
- [Com es pot jugar](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#com-es-pot-jugar)
- [Funcionament](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#funcionament)

## Creador

- [@HidroBarrera](https://github.com/HidroBarrera)

Hola, em dic Jordi Barrera, però en l'àmbit de les xarxes socials em faig conèixer com a Hidro Barrera o Hidro a seques.

Aquest videojoc ha sigut un repte per mi, he hagut d'investigar coses que no sa m'han ensenyat i he intentat moltes coses per millorar-lo, algunes estan implementades, altres en desenvolupament, però espero que el qui provi el joc pugui gaudir-lo i donar-me la seva retroacció.
## De què tracta

| ![Referencia](https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/MapaCiutat.png) | És un roguelike basat en estètica medieval on el jugador entra en un laberint amb la idea d'obtenir diners i fama, la qual cosa els enemics i altres aventures es posaran en el seu camí. Mitjançant la narrativa el jugador descobreix l'origen del laberint, el perquè existeix, qui va ser el seu creador i perquè els monstres apareixen en ordre de més dèbil a fort depenent de quin lloc del laberint estàs. |
|--------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|

El combat del joc és per torns, el jugador pot lluitar contra 1 enemic fins a un nombre de 4, els torns es decidiran per la velocitat, si algú augmenta la velocitat o depenent de les circumstàncies es pot arribar a fer dues accions per ronda.

Rondes: franja de les accions abans que es torni a fer un càlcul de velocitat.Al finalitzar un combat els enemics poden deixar pas a una selecció de potenciadors, els potenciadors augmentaran els efectes de les accions del jugador, permeten fer més mal o aplicar efectes alterats.

Després de seleccionar un potenciador s'obrirà una o diverses portes les quals et poden portar a una zona de recompensa o combat, la de combat és com diu el nom, la de recompensa et permet seleccionar un objecte d'una petita varietat, aquest objecte pot modificar estadístiques del jugador, depenent de les que té actualment.

La vista es top down, amb sprites pixel art d’uns 64bits, actualment el mapa seran prefabs pre dissenyats on es faran servir aleatòriament.

## Història

**La Llegenda dels Laberints Divins**

En un món remot i misteriós, els déus, eternament avorrits de la seva existència divina, van decidir crear una sèrie de laberints màgics. Aquests laberints, plens de tresors i perills indescriptibles, van ser dissenyats per desafiar la valentia i l'enginy dels aventurers mortals. Els déus, des dels seus troncs celestials, observaven amb interès i diversió com els humans s'endinsaven en aquestes estructures intricades, posant a prova les seves habilitats.

Els laberints no eren simples estructures de pedra i metall. Estaven imbuïts de màgia ancestral, canviant constantment la seva forma i contingut per mantenir el desafiament viu.


## Com es pot jugar

Per poder jugar pots entrar a l'enllaç següent de GitHub:
 [Pages del videojoc](https://hidrobarrera.github.io/DungeonDelve-WebGL/)

També pots descarregar un executable al següent enllaç: [Executable del joc](https://drive.google.com/drive/folders/1eTicZ1WTQque3Ai4r9bKwm9zcpQmQkkh?usp=sharing)

- Un cop descarregat descomprimeix la carpeta
- Seguidament executa el següent .exe
- Gaudeix el videojoc
## Funcionament

### Pantalla d'Inici

<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaInici_0.png" alt="Pantalla d'Inici"></td>
    <td>
      La pantalla d'inici conté els següents elements:
      <br>
<strong>Títol del Joc</strong>
<br>
<strong>Botó "Iniciar"</strong>
<br>
<strong>Botó "Sortir"</strong>
<br>
<strong>Botó "Informació"</strong>
    </td>
  </tr>
</table>

[Botó "Iniciar"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-onlineoffline) = 
Al apretar aquest boto accedeixes a la pàgina Online/Offline.

Botó "Sortir" = 
Surts del joc.

[Botó "Informació"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-dinformació) = 
Al apretar el boto accedeixes a la pàgina de Informació

---

### Pantalla d'Informació

<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaInformacio_0.png" alt="Pantalla d'Informació"></td>
    <td>
    <br>
      La pantalla d'informació mostra detalls sobre les diferents versions del joc:
      <br>
      <strong>Botó "Retornar"</strong>: Accedeix a la pantalla anterior
    </td>
  </tr>
</table>

[Botó "Retornar"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-dinici) = 
Al apretar aquest boto accedeixes a la pàgina anterior.

---

### Pantalla Online/Offline
<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaOnOffLine_0.png" alt="Pantalla Online/Offline"></td>
    <td>
    <br>
      La pantalla Online/Offline Conte els botons seguens:
      <br>
      <strong>Botó "Retornar"</strong>
      <br>
      <strong>Botó "Online"</strong>
      <br>
      <strong>Botó "Offline"</strong>
    </td>
  </tr>
</table>

[Botó "Retornar"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-dinici) = 
Al apretar aquest boto accedeixes a la pàgina anterior.

[Botó "Online"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-inici-seccio) = 
Al apretar aquest boto accedeixes a la pàgina de iniciar secció, el perque vols iniciar secció es per guardar el progres al nubul i poder jugar en altres dispositius si tens les cradencials.

[Botó "Offline"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-dinici) = 
Al apretar aquest boto accedeixes a la pantalla del joc, tingui en compte que no es guardara res al tancar el joc.

---

### Pantalla inici secció
<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaIniciSeccio_0.png" alt="Pantalla inici secció"></td>
    <td>
    <br>
      La pantalla inici secció Conte els botons seguens:
      <br>
      <strong>Botó "Retornar"</strong>
      <br>
      <strong>Botó "Iniciar"</strong>
      <br>
      <strong>Botó "Reguistre"</strong>
      <br>
      <strong>Camp usuari / correu</strong>
      <br>
      <strong>Camp contresenya</strong>
    </td>
  </tr>
</table>

[Botó "Retornar"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-dinici) = 
Al apretar aquest boto accedeixes a la pàgina anterior.

[Botó "Iniciar"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-dinici) = 
Al apretar aquest boto si les credencials son correctes accedeixes al joc.

[Botó "Reguistre"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-dinici) = 
Al apretar aquest boto accedeixes a la pàgina de reguistre, si no tens una compte hauras de reguistrar-te.

Camp usuari / correu = aqui es on poses el nom del usuari o el correu que has utilitzat per reguistrar-te.

Camp contresenya = aqui poses la teva contresenya, procura no compartirla i que contingui mes de 3 caracters.

Imatges d'exemple:
<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaOnOffLine_1.png" alt="Pantalla inici secció">
    </td>
    <td>
    <img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaOnOffLine_2.png" alt="Pantalla inici secció">
    </td>
    <td>
    <img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaOnOffLine_3.png" alt="Pantalla inici secció">
    </td>
  </tr>
</table>

---

### Pantalla de reguistre

<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaReguistre_0.png" alt="Pantalla de reguistre"></td>
    <td>
    <br>
      La pantalla inici secció Conte els botons seguens:
      <br>
      <strong>Botó "Registrar-se"</strong>
      <br>
      <strong>Botó "Cancel·lar"</strong>
      <br>
      <strong>Camp usuari</strong>
      <br>
      <strong>Camp correu</strong>
      <br>
      <strong>Camp contresenya</strong>
    </td>
  </tr>
</table>

[Botó "Retornar-se"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-dinici) = 
Al apretar aquest boto envies la informacio entrada a la base de dades i mostre per pantalla un missatge confirman la acció.

[Botó "Cancel·lar"](https://github.com/HidroBarrera/Dungeon-Delve/blob/main/README.md#pantalla-dinici) = 
Al apretar aquest boto accedeixes a la pàgina anterior.

Camp usuari = aqui es on poses el nom del usuari que vols fer servir pel registre

Camp correu = aqui es on poses el correu que vols fer servir pel registre

Camp contresenya = aqui poses la teva contresenya, procura no compartirla i que contingui mes de 3 caracters.

Imatges d'exemple:
<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaReguistre_1.png" alt="Pantalla inici secció">
    </td>
    <td>
    <img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaReguistre_2.png" alt="Pantalla inici secció">
    </td>
  </tr>
</table>

---

### Pantalla del videojoc, ciutat

<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/MapaCiutat.png" alt="Pantalla de reguistre"></td>
    <td>
    <img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaControls.png" alt="Pantalla de reguistre">
    </td>
  </tr>
</table>

Mapa de la ciutat = Aqui podem veure com es la ciutat, al final de la ciutat veurem el que es un portal, el qual ens portara al labarint.

Pantalla de controls = En aquesta pantalla podem veure que el mobiment es amb wasd i si apretem esc entrem en una pantalla de pausa.

### Pantalla del videojoc, labarint

<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/MapaDungeon_0.png" alt="Pantalla de reguistre"></td>
  </tr>
</table>

Mapa del labarint = Aqui podem veure com es la primera sala del labarint, aqui podem trobar enemics els quals podem esquivar o interectuar amb ells.

Monstres = Si colisionem amb algun entrerem en el combat.

---

### Pantalla del videojoc, combat

<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/Combat_0.png" alt="Pantalla de reguistre">
    <img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/Combat_2.png" alt="Pantalla de reguistre"></td>
    <td>
        A la pantalla de combat observem el seguent:
      <br>
      <strong>Personatge</strong>
      <br>
      <strong>Grup d'enemics</strong>
      <br>
      <strong>Barres de vida</strong>
      <br>
      <strong>Camp amb botons / text</strong>
      <br>
      <strong>Botons laterals</strong>
    </td>
  </tr>
</table>

Personatge = Personatge controlat pel jugador.

Grup d'enemics = Al entrar a combat es fa una tria aleatoria entre varies llistes d'enemics i dintre la pantalla de combat es mostren els que t'hauras d'enfrontar.

Barres de vida = Son les barres de color verd o vermell, les quals ensenyen la vida que tenen cada personatge.

Camp amb botons / text = Aquest camp canviara d'apanent la situacio en la que et trobis.
Els boton de color blau amb una imatge son les accions que pots arribar a fer, les quals estan explicades a la pantalla informacio explicada mes endevan.

Botons laterals = Hi han dos botons el primer entres a la pantalla de pause, per si vols sortir del joc, del labarint o de la partida. El seguent boto, que te una interogant, es el boto d'informacio.

### Pantalla del videojoc, combat

<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/Combat_3.png" alt="Pantalla de reguistre">
    </td>
    <td>
        En aquesta pantalla podem trobar les estedistiques del personatge
    </td>
  </tr>
</table>

<table>
  <tr>
    <td>
    <img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/Combat_4.png" alt="Pantalla de reguistre">
    </td>
    <td>
        Pantalla amb un petit tutorial de com atacar a un enemic
    </td>
  </tr>
</table>

<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/Combat_5.png" alt="Pantalla de reguistre">
    </td>
    <td>
        Explicacio del que fan cada una de les accions del personatge.      
    </td>
  </tr>
</table>
