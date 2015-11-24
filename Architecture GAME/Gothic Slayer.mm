<map version="1.0.1">
<!-- To view this file, download free mind mapping software FreeMind from http://freemind.sourceforge.net -->
<node CREATED="1448363275256" ID="ID_1704793501" MODIFIED="1448363294206" TEXT="Gothic Slayer">
<node CREATED="1448363296606" HGAP="19" ID="ID_760861186" MODIFIED="1448364274397" POSITION="right" TEXT="Menu Game" VSHIFT="1">
<node CREATED="1448363324035" HGAP="29" ID="ID_1631486277" MODIFIED="1448371791612" TEXT="New Game" VSHIFT="40">
<node CREATED="1448363405335" ID="ID_686840833" MODIFIED="1448371832032" TEXT="Menu Game">
<node CREATED="1448364052926" ID="ID_1845017692" MODIFIED="1448364059257" TEXT="Pause"/>
<node CREATED="1448364141927" ID="ID_564807929" MODIFIED="1448364159357" TEXT="Go Menu Home"/>
<node CREATED="1448364159596" ID="ID_1422708843" MODIFIED="1448364162867" TEXT="Exit Game"/>
</node>
<node CREATED="1448363347126" ID="ID_1665809786" MODIFIED="1448376813444" TEXT="Player">
<node CREATED="1448363433975" FOLDED="true" ID="ID_282311710" MODIFIED="1448376819844" TEXT="Stats">
<node CREATED="1448364383808" ID="ID_495051252" MODIFIED="1448375299017">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <ul>
      <li>
        <i>stock l'ensembles des variables des actions de l' entity</i>

        <ul>
          <li>
            int :<b>&#160;m_life </b>

            <ul>
              <li>
                use for &#160;life of entity
              </li>
            </ul>
          </li>
          <li>
            int :<b>&#160;m_lifeMax</b>

            <ul>
              <li>
                use for set&#160;life limite of entity
              </li>
            </ul>
          </li>
          <li>
            &#160;bool <b>m_isDead</b>

            <ul>
              <li>
                check if life equals 0
              </li>
            </ul>
          </li>
          <li>
            bool <b>m_isSpectral</b>

            <ul>
              <li>
                check if player is on spectral mode
              </li>
            </ul>
          </li>
          <li>
            
          </li>
          <li>
            int <b>m_powerDamage</b>

            <ul>
              <li>
                use for damage sword
              </li>
            </ul>
          </li>
          <li>
            float <b>m_speedVelocity</b>

            <ul>
              <li>
                use for movement<br />
              </li>
            </ul>
          </li>
          <li>
            <br />
            
          </li>
          <li>
            int <b>m_keys</b>

            <ul>
              <li>
                use for open&#160;&#160;doors
              </li>
            </ul>
          </li>
          <li>
            int <b>m_arrowsCount</b>

            <ul>
              <li>
                use for shoot with bow
              </li>
            </ul>
          </li>
          <li>
            int <b>m_bombsCount</b>

            <ul>
              <li>
                use for detroy breakable wall and damage enemies
              </li>
            </ul>
          </li>
          <li>
            int <b>m_manasCount</b>

            <ul>
              <li>
                use for shoot fireball
              </li>
            </ul>
          </li>
          <li>
            bool <b>m_bow</b>

            <ul>
              <li>
                use to select this object
              </li>
            </ul>
          </li>
          <li>
            bool <b>m_bomb</b>

            <ul>
              <li>
                use to select this object
              </li>
            </ul>
          </li>
          <li>
            bool <b>m_fireRod</b>

            <ul>
              <li>
                use to select this object
              </li>
            </ul>
          </li>
          <li>
            Weapon <b>m_weaponSelect</b>

            <ul>
              <li>
                Type of Weapon (Bomb, Bow or Fire Rod)
              </li>
            </ul>
          </li>
        </ul>
      </li>
    </ul>
  </body>
</html>
</richcontent>
</node>
</node>
<node CREATED="1448363453965" ID="ID_9202325" MODIFIED="1448363468366" TEXT="Movement"/>
<node CREATED="1448363468775" ID="ID_80557089" MODIFIED="1448363604476" TEXT="Attack Sword"/>
<node CREATED="1448375373657" ID="ID_1254834092" MODIFIED="1448375419117" TEXT="Use Object">
<node CREATED="1448363553025" ID="ID_70789450" MODIFIED="1448375401127" TEXT="Weapon">
<node CREATED="1448363867006" ID="ID_111239329" MODIFIED="1448363869467" TEXT="Bomb"/>
<node CREATED="1448363871746" ID="ID_1199824569" MODIFIED="1448363876137" TEXT="Arrow"/>
<node CREATED="1448363876366" ID="ID_1518376491" MODIFIED="1448363881187" TEXT="FireBall"/>
</node>
</node>
<node CREATED="1448363488395" ID="ID_1393868122" MODIFIED="1448363609786" TEXT="UI Player">
<node CREATED="1448363496755" ID="ID_915151473" MODIFIED="1448363629306" TEXT="Change Object"/>
</node>
</node>
<node CREATED="1448363365335" ID="ID_1290125637" MODIFIED="1448364369248" TEXT="Enemies">
<node CREATED="1448363636825" ID="ID_1972759309" MODIFIED="1448363639956" TEXT="Stats"/>
<node CREATED="1448363640295" ID="ID_369390404" MODIFIED="1448363647736" TEXT="Auto-Move"/>
<node CREATED="1448363649135" ID="ID_1610839103" MODIFIED="1448363654787" TEXT="Auto-Attack"/>
<node CREATED="1448363655226" ID="ID_304687009" MODIFIED="1448363661377" TEXT="Drop Item"/>
</node>
<node CREATED="1448363370705" ID="ID_18716929" MODIFIED="1448371814462" TEXT="Dungeon">
<node CREATED="1448363669726" ID="ID_1729547206" MODIFIED="1448371772952" TEXT="Rooms">
<node CREATED="1448363697767" ID="ID_307793708" MODIFIED="1448363708237" TEXT="Block movable"/>
<node CREATED="1448363709636" ID="ID_1085816513" MODIFIED="1448376824104" TEXT="Switch">
<node CREATED="1448363726116" ID="ID_576847778" MODIFIED="1448376869914" TEXT="Pression plate"/>
<node CREATED="1448363731526" ID="ID_1963490114" MODIFIED="1448376890314" TEXT="Target button"/>
</node>
<node CREATED="1448363738846" ID="ID_823866407" MODIFIED="1448377013859" TEXT="Totem / Rune">
<node CREATED="1448372191972" ID="ID_975685112" MODIFIED="1448372260863">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      Totem = double state
    </p>
    <p>
      Rune = only spectral form to physical form
    </p>
  </body>
</html>
</richcontent>
</node>
</node>
<node CREATED="1448363750566" ID="ID_63725907" MODIFIED="1448376828224" TEXT="Trap">
<node CREATED="1448363761736" ID="ID_1060810491" MODIFIED="1448363766507" TEXT="Arrows"/>
</node>
<node CREATED="1448363768426" ID="ID_1715287891" MODIFIED="1448363771467" TEXT="Doors"/>
<node CREATED="1448363777766" ID="ID_576587563" MODIFIED="1448376833004" TEXT="Chests">
<node CREATED="1448363804856" ID="ID_1055192531" MODIFIED="1448363842387" TEXT="Object"/>
</node>
<node CREATED="1448363939066" ID="ID_378983190" MODIFIED="1448376834324" TEXT="Items">
<node CREATED="1448363942756" ID="ID_1040714715" MODIFIED="1448363945587" TEXT="Heart"/>
<node CREATED="1448363945816" ID="ID_1155971366" MODIFIED="1448376836214" TEXT="Mun">
<node CREATED="1448363956486" ID="ID_1416048404" MODIFIED="1448363961607" TEXT="Arrows"/>
<node CREATED="1448363961886" ID="ID_243100251" MODIFIED="1448363968807" TEXT="Bomb"/>
<node CREATED="1448363969046" ID="ID_540533226" MODIFIED="1448363970377" TEXT="Mana"/>
</node>
</node>
</node>
</node>
<node CREATED="1448363665256" ID="ID_1247705324" MODIFIED="1448363669507" TEXT="Camera">
<node CREATED="1448369698518" ID="ID_1381977463" MODIFIED="1448369727608" TEXT="resolution "/>
</node>
</node>
<node CREATED="1448364175616" ID="ID_964095774" MODIFIED="1448364180197" TEXT="Exit Game"/>
<node CREATED="1448364185976" ID="ID_302164541" MODIFIED="1448364189187" TEXT="Credit"/>
</node>
</node>
</map>
