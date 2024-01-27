using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnapToTheme : MonoBehaviour
{
    public ScrollRect scrollRect;
    public RectTransform contentPanel;
    public RectTransform sampleListItem;

    //public HorizontalLayoutGroup HLG;
    bool _isSnapped;

    public float snapForce = 1;
    float _speedSnap = 1;
    // Start is called before the first frame update
    void Start()
    {
        _isSnapped = false;
    }

    // Update is called once per frame
    void Update()
    {
        int currentItem = Mathf.RoundToInt(0 - (contentPanel.localPosition.x / (sampleListItem.rect.width)));
        PlayerPrefs.SetInt("theme_index", currentItem);
        Debug.Log(currentItem);
        if (scrollRect.velocity.magnitude < 200 && !_isSnapped)
        {
            scrollRect.velocity = Vector2.zero;
            _speedSnap += snapForce * Time.deltaTime;
            contentPanel.localPosition = new Vector3(
               Mathf.MoveTowards(contentPanel.localPosition.x, 0 - currentItem * (sampleListItem.rect.width), _speedSnap), contentPanel.localPosition.y, contentPanel.localPosition.z);
            if (contentPanel.localPosition.x == 0 - (currentItem * (sampleListItem.rect.width)))
            {

                _isSnapped = true;
            }
        }
        if (scrollRect.velocity.magnitude > 200)
        {
            _isSnapped = false;
            _speedSnap = 0;
        }
    }
}
