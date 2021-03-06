using UnityEngine;
using TMPro;
using Inventory.Model;
using UnityEngine.UI;
using Inventory.Presenter;

namespace Inventory.View
{

    /// <summary>
    /// Only displays a given InventoryItemData object's full details. Nothing more.
    /// Doesn't handle any logical operation, as this is a view class.
    /// 
    /// -Renelie Salazar
    /// </summary>
    public class InventoryInfoPanelView : MonoBehaviour
    {

        #region Inspector Fields

        [SerializeField]
        private TextMeshProUGUI textName;

        [SerializeField]
        private TextMeshProUGUI textDescription;

        [SerializeField]
        private TextMeshProUGUI textStats;

        [SerializeField]
        private Image imageIcon;

        #endregion

        #region Public API

        public void DisplayInfo(InventoryItemData itemData, IInventoryPresenter presenter)
        {
            if (itemData == null)
            {
                return;
            }

            imageIcon.sprite = presenter.GetSettings().Icons[itemData.IconIndex];
            textName.text = itemData.Name;
            textDescription.text = itemData.Description;
            textStats.text = itemData.Stat.ToString();
        }

        #endregion //Public API

    }

}