
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

També pots descarregar un executable al següent enllaç:

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
<strong>Títol del Joc</strong>: "Dungeon Delve the Eternal Trial".
<br>
<strong>Botó "Iniciar"</strong>: Inicia el joc.
<br>
<strong>Botó "Sortir"</strong>: Surt del joc.
<br>
<strong>Botó "Informació"</strong>: Accedeix a la pantalla d'informació sobre les versions del joc.
    </td>
  </tr>
</table>

### Pantalla d'Informació

<table>
  <tr>
    <td><img src="https://github.com/HidroBarrera/Image-DDET-Readmy/blob/main/PantallaInformacio_0.png" alt="Pantalla d'Informació"></td>
    <td>
    <br>
      La pantalla d'informació mostra detalls sobre les diferents versions del joc:
      <strong>Botó "Retornar"</strong>: Accedeix a la pantalla anterior
    </td>
  </tr>
</table>
