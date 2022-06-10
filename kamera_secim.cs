using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_secim : MonoBehaviour
{
    public GameObject _yasam1;
    public GameObject _yasam2;
    public GameObject _yatakOdasý;
    public GameObject _banyo;
    public GameObject buton;
    public GameObject menu;
    void Start()
    {
        Baslangic();
    }
    public void Baslangic()
    {
        _yasam1.SetActive(false);
        _yasam2.SetActive(false);
        _yatakOdasý.SetActive(false);
        _banyo.SetActive(false);
        buton.SetActive(true);
        menu.SetActive(false);
    }
    public void Yasam1()
    {
        _yasam1.SetActive(true);
        _yasam2.SetActive(false);
        _yatakOdasý.SetActive(false);
        _banyo.SetActive(false);
        buton.SetActive(false);
        menu.SetActive(true);
    }
    public void Yasam2()
    {
        _yasam1.SetActive(false);
        _yasam2.SetActive(true);
        _yatakOdasý.SetActive(false);
        _banyo.SetActive(false);
        buton.SetActive(false);
        menu.SetActive(true);
    }
    public void Yatak()
    {
        _yasam1.SetActive(false);
        _yasam2.SetActive(false);
        _yatakOdasý.SetActive(true);
        _banyo.SetActive(false);
        buton.SetActive(false);
        menu.SetActive(true);
    }
    public void Banyo()
    {
        _yasam1.SetActive(false);
        _yasam2.SetActive(false);
        _yatakOdasý.SetActive(false);
        _banyo.SetActive(true);
        buton.SetActive(false);
        menu.SetActive(true);
    }
}
