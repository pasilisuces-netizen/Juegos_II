using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [System.Serializable]
    public class Panel { public string id; public GameObject root; }

    [SerializeField] private List<Panel> panels;
    [SerializeField] private string startPanel = "Main";

    private void Start() => ShowPanel(startPanel);

    public void ShowPanel(string id)
    {
        foreach (var p in panels) p.root.SetActive(p.id == id);
    }
}