﻿using FlaUI.Core;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns;
using FlaUI.UIA2.Converters;
using FlaUI.UIA2.Identifiers;
using UIA = System.Windows.Automation;

namespace FlaUI.UIA2.Patterns
{
    public class SelectionPattern : SelectionPatternBase<UIA.SelectionPattern>
    {
        public static readonly PatternId Pattern = PatternId.Register(AutomationType.UIA2, UIA.SelectionPattern.Pattern.Id, "Selection", AutomationObjectIds.IsSelectionPatternAvailableProperty);
        public static readonly PropertyId CanSelectMultipleProperty = PropertyId.Register(AutomationType.UIA2, UIA.SelectionPattern.CanSelectMultipleProperty.Id, "CanSelectMultiple");
        public static readonly PropertyId IsSelectionRequiredProperty = PropertyId.Register(AutomationType.UIA2, UIA.SelectionPattern.IsSelectionRequiredProperty.Id, "IsSelectionRequired");
        public static readonly PropertyId SelectionProperty = PropertyId.Register(AutomationType.UIA2, UIA.SelectionPattern.SelectionProperty.Id, "Selection").SetConverter(AutomationElementConverter.NativeArrayToManaged);
        public static readonly EventId InvalidatedEvent = EventId.Register(AutomationType.UIA2, UIA.SelectionPattern.InvalidatedEvent.Id, "Invalidated");

        public SelectionPattern(BasicAutomationElementBase basicAutomationElement, UIA.SelectionPattern nativePattern) : base(basicAutomationElement, nativePattern)
        {
        }
    }

    public class SelectionPatternProperties : ISelectionPatternProperties
    {
        public PropertyId CanSelectMultiple => SelectionPattern.CanSelectMultipleProperty;
        public PropertyId IsSelectionRequired => SelectionPattern.IsSelectionRequiredProperty;
        public PropertyId Selection => SelectionPattern.SelectionProperty;
    }

    public class SelectionPatternEvents : ISelectionPatternEvents
    {
        public EventId InvalidatedEvent => SelectionPattern.InvalidatedEvent;
    }
}
