using UnityEngine;

namespace VBM {
    public class View {
        public ViewConfig config { get; internal set; }
        public Transform transform { get; protected set; }

        public virtual void SetViewAsset(GameObject gameObject) {
            gameObject.name = config.name;
            this.transform = gameObject.transform;
            ViewModelBinding binding = gameObject.GetComponent<ViewModelBinding>();
            binding.view = this;
            MonoBehaviourEvent objectEvent = gameObject.AddComponent<MonoBehaviourEvent>();
            objectEvent.onStartEvent += OnCreated;
            objectEvent.onEnableEvent += OnShow;
            objectEvent.onDisableEvent += OnHide;
            objectEvent.onDestroyEvent += OnDestroyed;
        }

        public void DestroyAsset() {
            Object.Destroy(transform.gameObject);
            transform = null;
        }

        public bool IsShowing() {
            return transform != null && transform.gameObject.activeSelf;
        }

        public virtual void Show() {
            ViewManager.Instance.ShowView(this);
        }

        public virtual void Hide() {
            ViewManager.Instance.HideView(this);
        }

        public virtual void OnCreated() { }
        public virtual void OnShow() { }
        public virtual void OnHide() { }
        public virtual void OnDestroyed() { }
    }
}