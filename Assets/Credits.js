#pragma strict

var speed = 0.2;
var crawling = true;
 
function Start()
{
    // init text here, more space to work than in the Inspector (but you could do that instead)
    var tc = GetComponent(GUIText);
    var creds = "Dekeract\n\n\n\n\n\n\n\n\n\n";
    creds += "Lead Designer: Danny Wilson\n";
    creds += "Test and Documentation Lead: Matthew Coelho\n";
    creds += "Project Manager: Rob Moore\n\n\n\n\n\n";
    creds += "Music: incompetech.com\n";
    creds += "Audio: soundbible.com\n";
	tc.text= creds; 
}

function Update ()
{
    if (!crawling)
        return;
    transform.Translate(Vector3.up * Time.deltaTime * speed);
    if (gameObject.transform.position.y > 2)
    {
        crawling = false;
        Application.LoadLevel("MainMenu");
    }
}