using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

namespace WorldTime
{
    [RequireComponent(typeof(TMP_Text))]
    public class worldTDisplay : MonoBehaviour
    {
        [SerializeField]
        private worldtime _worldTime;
        private TMP_Text _text;

        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
            _worldTime.WorldTimeChanged += OnWorldTimeChanged;
        }

        private void OnDestroy()
        {
            _worldTime.WorldTimeChanged -= OnWorldTimeChanged;
        }
        private void OnWorldTimeChanged(object sender, TimeSpan newTime)
        {
            _text.SetText(newTime.ToString(@"hh\:mm"));
        }
    }
}
