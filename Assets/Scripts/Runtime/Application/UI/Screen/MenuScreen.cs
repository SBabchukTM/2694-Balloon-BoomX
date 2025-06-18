using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Runtime.UI
{
    public class MenuScreen : UiScreen
    {
        [SerializeField] private SimpleButton _playButton;
        [SerializeField] private SimpleButton _accountButton;
        [SerializeField] private SimpleButton _settingsButton;
        [SerializeField] private SimpleButton _leaderboardButton;
        [SerializeField] private SimpleButton _rulesButton;
        [SerializeField] private SimpleButton _privacyPolicyButton;
        [SerializeField] private TextMeshProUGUI _balanceText;

        public event Action OnPlayPressed;
        public event Action OnAccountPressed;
        public event Action OnSettingsPressed;
        public event Action OnLeaderboardPressed;
        public event Action OnRulesPressed;
        public event Action OnPrivacyPolicyPressed;

        private void OnDestroy()
        {
            _accountButton.Button.onClick.RemoveAllListeners();
            _settingsButton.Button.onClick.RemoveAllListeners();
            _leaderboardButton.Button.onClick.RemoveAllListeners();
            _rulesButton.Button.onClick.RemoveAllListeners();
            _privacyPolicyButton.Button.onClick.RemoveAllListeners();
            _playButton.Button.onClick.RemoveAllListeners();
        }

        public void Initialize(int balance)
        {
            _accountButton.Button.onClick.AddListener(() => OnAccountPressed?.Invoke());
            _settingsButton.Button.onClick.AddListener(() => OnSettingsPressed?.Invoke());
            _leaderboardButton.Button.onClick.AddListener(() => OnLeaderboardPressed?.Invoke());
            _rulesButton.Button.onClick.AddListener(() => OnRulesPressed?.Invoke());
            _privacyPolicyButton.Button.onClick.AddListener(() => OnPrivacyPolicyPressed?.Invoke());
            _playButton.Button.onClick.AddListener(() => OnPlayPressed?.Invoke());
            _balanceText.text = balance.ToString();
        }
    }
}