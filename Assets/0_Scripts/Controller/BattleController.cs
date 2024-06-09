using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState1 { START, CHECTURN, PLAYER_ACCTION, PLAYER_SELECT_ENEMY, DOACTION, ENEMY_TURN, WON, LOST, STOP }
public class BattleController : MonoBehaviour
{
    #region //  [SerializeFild]  //
    [SerializeField] List<Transform> enemyBattleStation;
    [SerializeField] List<GameObject> enemyHPBar;
    [SerializeField] Image playerHPBar;
    [SerializeField] GameObject textPanel;
    [SerializeField] GameObject actionsPanel;
    [SerializeField] TextMeshProUGUI textStatCombat;
    [SerializeField] GameObject returnScene;
    #endregion

    #region //  Propietats  //
    private StatsEditor playerStats;
    private List<GameObject> enemyStats = new();
    public BattleState1 state;
    List<StatsEditor> baseList = new();
    List<StatsEditor> turnList = new();
    private string OnSelectedAction;
    private GameObject OnSelectedEnemy;
    private int enemyAlive = 0;
    #endregion

    #region //  Unity Methods  //
    void Start()
    {
        InstantiateGameObjectInCombat();
        CreateLists();
        CreateConstantUseList();

        state = BattleState1.START;
    }
    void Update()
    {
        switch (state)
        {
            case BattleState1.START:
                state = BattleState1.STOP;
                StartCoroutine(SetupBattle());
                break;

            case BattleState1.CHECTURN:
                state = BattleState1.STOP;
                ChecTurn();
                break;

            case BattleState1.PLAYER_ACCTION:
                StartCoroutine(PlayerAction());
                break;

            case BattleState1.DOACTION:
                state = BattleState1.STOP;
                PlayerAttack();
                break;

            case BattleState1.ENEMY_TURN:
                state = BattleState1.STOP;
                StartCoroutine(EnemyAction());
                break;

            case BattleState1.WON:
                returnScene.SetActive(true);
                break;

            case BattleState1.LOST:
                textStatCombat.text = "Has perdut";
                break;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (PlayerEnemySelect())
            {
                state = BattleState1.DOACTION;
            }
        }
    }
    #endregion

    #region //  Combat Controls [State] //
    IEnumerator SetupBattle() // = Instanciem els enemics i el jugador a la pantalla = //
    {
        textStatCombat.text = "Un grup d'enemic et talla el pas";
        yield return new WaitForSeconds(1.5f);
        state = BattleState1.CHECTURN;
    }
    #endregion

    #region //  CombatControls [Player Actions]  //
    IEnumerator PlayerAction()
    {
        textStatCombat.text = "Selecciona una acció";

        yield return new WaitForSeconds(1.5f);

        textPanel.SetActive(false);
        actionsPanel.SetActive(true);
    }
    public void OnStrongAttack()
    {
        if (state != BattleState1.PLAYER_ACCTION) { return; }
        OnSelectedAction = "StrongAttack";
        state = BattleState1.PLAYER_SELECT_ENEMY;
    }
    public void OnWeakAttack()
    {
        if (state != BattleState1.PLAYER_ACCTION) { return; }
        OnSelectedAction = "WeakAttack";
        state = BattleState1.PLAYER_SELECT_ENEMY;
    }
    public void OnDeffens()
    {
        if (state != BattleState1.PLAYER_ACCTION) { return; }
        OnSelectedAction = "Deffens";
        state = BattleState1.PLAYER_SELECT_ENEMY;
    }
    bool PlayerEnemySelect()
    {
        if (state != BattleState1.PLAYER_SELECT_ENEMY) { return false; }

        textPanel.SetActive(true);
        actionsPanel.SetActive(false);
        textStatCombat.text = "Selecciona a un enemic";

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null && !hit.collider.gameObject.CompareTag("Player") && hit.collider.gameObject.CompareTag("Enemy"))
        {
            OnSelectedEnemy = hit.collider.gameObject;
            return true;
        }
        return false;
    }
    void PlayerAttack()
    {
        bool isDead = false;
        switch (OnSelectedAction)
        {
            case "StrongAttack":
                isDead = StrongAttack();
                break;
            case "WeakAttack":
                isDead = WeakAttack();
                break;
            case "Deffens":
                break;
        }
        turnList.Remove(playerStats);

        GameObject bar = enemyHPBar[OnSelectedEnemy.GetComponent<StatsEditor>().PositionList].transform.Find("Hp" + OnSelectedEnemy.GetComponent<StatsEditor>().PositionList).gameObject;
        bar.GetComponent<UnityEngine.UI.Image>().fillAmount = OnSelectedEnemy.GetComponent<StatsEditor>().VidaReturnSet / OnSelectedEnemy.GetComponent<StatsEditor>().MaxVidaReturnSet;

        OnSelectedAction = "";

        CheckEnemyIsDead(isDead);
    }
    #endregion

    #region //  CombatControls [Enemy Actions]  //
    IEnumerator EnemyAction()
    {
        state = BattleState1.STOP;
        textStatCombat.text = turnList[0].Name + " vol atacar";
        yield return new WaitForSeconds(1.5f);
        EnemyPerformAttack(turnList[0]);
        if (state != BattleState1.LOST)
        {
            if (turnList.Count() == 0)
            {
                CreateConstantUseList();
            }
            state = BattleState1.CHECTURN;
        }
    }
    void EnemyPerformAttack(StatsEditor enemy)
    {
        bool isDead = EnemyAttack(enemy);

        playerHPBar.fillAmount = playerStats.VidaReturnSet / playerStats.MaxVidaReturnSet;
        turnList.Remove(enemy);

        if (isDead)
        {
            state = BattleState1.LOST;
        }
    }
    #endregion

    #region //  Damage Calculator  //
    // Calcul del mal de l'atac fort
    bool StrongAttack()
    {
        float dmg;

        if (CritChange()) { dmg = ((playerStats.AtacReturnSet * (playerStats.CritDamageReturnSet / 100)) - OnSelectedEnemy.GetComponent<StatsEditor>().DefensaReturnSet); }
        else { dmg = (playerStats.AtacReturnSet - OnSelectedEnemy.GetComponent<StatsEditor>().DefensaReturnSet); }

        DoDmage(dmg);

        if (OnSelectedEnemy.GetComponent<StatsEditor>().VidaReturnSet <= 0) { return true; }
        return false;
    }
    bool WeakAttack()
    {
        float dmg;

        if (CritChange()) { dmg = (((playerStats.AtacReturnSet * (65 / 100)) * (playerStats.CritDamageReturnSet / 100)) - OnSelectedEnemy.GetComponent<StatsEditor>().DefensaReturnSet); }
        else { dmg = ((playerStats.AtacReturnSet * (65 / 100)) - OnSelectedEnemy.GetComponent<StatsEditor>().DefensaReturnSet); }

        DoDmage(dmg);
        playerStats.VelocitatReturnSet += (playerStats.VelocitatReturnSet * (10 / 100));

        if (OnSelectedEnemy.GetComponent<StatsEditor>().VidaReturnSet <= 0) { return true; }
        return false;
    }
    void DoDmage(float dmg)
    {
        if (dmg > 0)
        {
            OnSelectedEnemy.GetComponent<StatsEditor>().VidaReturnSet -= dmg;
        }
    }
    void Deffens(int torn) // refer
    {
        if (playerStats.GetComponent<StatsEditor>().DamageReductionReturnSet != 0)
        {
            playerStats.GetComponent<StatsEditor>().DamageReductionReturnSet = 10;
        }
    }

    // Calcul del mal de l'enemic atacan
    bool EnemyAttack(StatsEditor enemy)
    {
        if (playerStats.DamageReductionReturnSet != 0)
        {
            playerStats.VidaReturnSet -= ((enemy.AtacReturnSet) - playerStats.DefensaReturnSet) / playerStats.DamageReductionReturnSet;
        }
        else { playerStats.VidaReturnSet -= ((enemy.AtacReturnSet) - playerStats.DefensaReturnSet); }

        if (playerStats.VidaReturnSet <= 0) { return true; }
        return false;
    }

    // Calcul de percentatge critic
    bool CritChange()
    {
        System.Random rng = new();
        bool crit = false;
        int num = rng.Next(1, 100);
        if (playerStats.CritChangeReturnSet >= num)
        {
            crit = true;
        }
        return crit;
    }
    #endregion

    #region //  List Contols  //
    void CreateLists()
    {
        // Neteja les llistes
        baseList.Clear();

        foreach (GameObject enemy in StaticFunc.ReturnEnemyList().list)
        {
            baseList.Add(enemy.GetComponent<StatsEditor>());
        }
        baseList.Add(GameObject.FindWithTag("Player").GetComponent<StatsEditor>());
        enemyAlive = baseList.Count() - 1;
        // Crea una nova llista ordenada de la llista base a la real
        baseList = baseList.OrderByDescending(character => character.VelocitatReturnSet).ToList();
    }
    void CreateConstantUseList()
    {
        foreach (StatsEditor item in baseList)
        {
            if (item.Name != "Play" && item.VidaReturnSet <= 0)
            {
                item.GetStats();
            }
            turnList.Add(item);
        }
        // Llista temporal, la qual s'anira editan
        List<StatsEditor> tempList = new();

        // Comproba si el jugador es el primer
        if (baseList[0].Name == "Player")
        {
            if (baseList.Count != 1)
            {
                // Comprova si el jugador duplica la velocitat del enemic mes rapid
                if (baseList[1].VelocitatReturnSet * 2 <= baseList[0].VelocitatReturnSet)
                    // Afegeix el jugador al final de la llista
                    turnList.Add(baseList[0]);
            }
        }
        // El jugador no es el primer
        else
        {
            // Busca el jugador de la llista i el guarda a una variable
            StatsEditor Player = baseList.First(character => character.name == "Player");
            // Passa per les possisions de la llista fins a trobar el jugador
            foreach (var character in baseList.TakeWhile(character => character != Player))
            {
                print(character);
                // Comprova si la velocitat del jugador es la maitat del enemic
                if (Player.VelocitatReturnSet * 2 <= character.VelocitatReturnSet)
                    // Afegeix l'enemic a la llista temporal
                    tempList.Add(character);
                else break;
            }
            // Comproba si la llista temporal no esta buida
            if (tempList.Count > 0)
            {
                // Comproba els enemics de la llista temporal
                foreach (var characterInTempList in tempList)
                {
                    // Afageix els enemics al final de la llista
                    turnList.Add(characterInTempList);
                }
            }
        }
    }
    void ChecTurn()
    {
        if (turnList.Count == 0) { CreateConstantUseList(); }
        if (turnList[0].name == "Player")
        {
            state = BattleState1.PLAYER_ACCTION;
        }
        else
        {
            state = BattleState1.ENEMY_TURN;
        }
    }
    #endregion

    #region //  Functions of all regions  //
    private void InstantiateGameObjectInCombat()
    {
        int x = 0;
        foreach (GameObject character in StaticFunc.ReturnEnemyList().list)
        {
            GameObject newEnemyObject = Instantiate(character, enemyBattleStation[x].transform);
            newEnemyObject.GetComponent<StatsEditor>().PositionList = x;
            enemyStats.Add(newEnemyObject);
            enemyHPBar[x].SetActive(true);
            x++;
        }
        playerStats = GameObject.FindWithTag("Player").GetComponent<StatsEditor>();
    }
    private void CheckEnemyIsDead(bool isDead)
    {
        if (isDead)
        {
            enemyAlive -= 1;
            OnSelectedEnemy.SetActive(false);
            enemyHPBar[OnSelectedEnemy.GetComponent<StatsEditor>().PositionList].SetActive(false);
            turnList.Remove(OnSelectedEnemy.GetComponent<StatsEditor>());
            baseList.Remove(OnSelectedEnemy.GetComponent<StatsEditor>());
            if (enemyAlive == 0)
            {
                state = BattleState1.WON;
            }
        }
        if (turnList.Count == 0)
        {
            CreateConstantUseList();
        }
        if (state != BattleState1.WON)
        {
            state = BattleState1.CHECTURN;
        }
    }
    #endregion
}
