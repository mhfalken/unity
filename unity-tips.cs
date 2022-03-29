Editor help (MVS 2019):
for/if/while/foreach/switch <TAB>

C# scripts

// Functions
void Start() { }    // Called once during srtup
void Update() { }   // Called for every frame
private void OnTriggerEnter2D(Collider2D collision) { }     // Called for trigger collisons
private void OnCollisionEnter2D(Collision2D collision) { }  // Called for collisions

// Debug (visible on the Console window)
Debug.Log("Text " + value);

// External fields (accessed from Unity GUI)
[SerializeField] Text xxtext;
[SerializeField] GameObject[] xxList;

//Componets (names can be found in the Unity GUI inspector - just remove the spaces)
xxComp = GetComponent<Rigidbody2D>();
xxComp.enabled = false;     // Disable component

// Movement
xxRidgitBody2D.AddForce(new Vector2(xForce, yForce));  // Jump
xxRidgitBody2D.velocity = new Vector2(xSpeed, ySpeed); // Move
xxSprite.flipX = false;  // Flip image

// Tag compare
if (xxCollision.gameObject.CompareTag("Frog")) { }

// Animate
xxAnimator.SetTrigger("die");  // Start animation (in Animator) NB: exactly same name!

// Keys (can be found in Edit->Project settings->Input manager)
dir = Input.GetAxisRaw("Horizontal");   [-1, 0, 1]
jumpKey = Input.GetAxisRaw("Jump");     [0, 1]

// Text (require UI.Text)
[SerializeField] Text xxtext;
xxText.text = "Lives: " + xxLevel;

// Sound (require setup script)
[SerializeField] AudioClip xxSound;
SoundManager.instance.PlaySound(xxsound);

// Co-routine (special cases)
StartCoroutine(xxDelay());
IEnumerator xxDelay()
{
    yield return new WaitForSeconds(2);
}

// Vectors
new Vector2(x, y);
new Vector3(x, y, z);
xxDist = Vector2.Distance(transform.position, transform.position);
transform.position = Vector2.MoveTowards(xxFrom.transform.position, xxTo.transform.position, Time.deltaTime * speed);


// Utility
xxNewLevel = Mathf.Clamp(xxLevel - 1, 0, 3);  // Clamp value: Value, min, max
Time.deltaTime; // Time between two frames


// Info/space/tip for serializeFields (cosmetic GUI only)
[Header("Info text")]
[Space]
[Tooltip("tip")]
