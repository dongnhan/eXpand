﻿using DevExpress.Xpo;
using eXpand.ExpressApp.AdditionalViewControlsProvider.Logic;
using eXpand.ExpressApp.Attributes;

namespace FeatureCenter.Module.Navigation
{
    [AdditionalViewControlsRule(Captions.Header + " " + Captions.HeaderNonPersistent, "1=1", "1=1", Captions.HeaderNonPersistent, Position.Top)]
    [AdditionalViewControlsRule(Captions.ViewMessage + " " + Captions.HeaderNonPersistent, "1=1", "1=1", Captions.ViewMessageNonPersistent, Position.Bottom)]
    [NonPersistent, System.ComponentModel.DisplayName(Captions.HeaderNonPersistent)]
    [NavigationItem("Navigation/NonPersistent", "NonPersistentObject_DetailView")]
    public class NonPersistentObject
    {
        public string StringProperty {
            get { return "I am a session less non persistent object "; }
            set {  }
        }
    }
}
