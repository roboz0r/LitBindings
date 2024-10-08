module App

open Fable.Core
open Browser
open Lit
open GettingStarted

let start () =
    Lit.DefineCustomElement<SimpleGreeting>("simple-greeting")
    Lit.DefineCustomElement<MyPage>("my-page")
    Lit.DefineCustomElement<MyReactive>("my-reactive")
    Lit.DefineCustomElement<CustomChangeDetection>("custom-change-detection")
    Lit.DefineCustomElement<ClassStyling>("class-styling")
    Lit.DefineCustomElement<SlottedStyling>("slotted-styling")
    Lit.DefineCustomElement<DynamicStyling>("dynamic-styling")
    Lit.DefineCustomElement<DynamicStyling2>("dynamic-styling2")
    Lit.DefineCustomElement<ClockElement>("clock-element")
    Lit.DefineCustomElement<MyContextElement>("my-context-element")
    Lit.DefineCustomElement<MyContextApp>("my-context-app")

    let el = document.getElementById ("app")
    if el <> null then

        let content =
            Lit.html
                $"""
            <simple-greeting></simple-greeting>
            <simple-greeting name="Rob"></simple-greeting>
            <my-page></my-page>
            <my-reactive></my-reactive>
            <custom-change-detection></custom-change-detection>
            <class-styling></class-styling>
            <class-styling class="blue"></class-styling>
            <slotted-styling>
                <p>Slotted content</p>
                <span slot="hi">Slotted content with slot name</span>
            </slotted-styling>
            <dynamic-styling></dynamic-styling>
            <dynamic-styling2></dynamic-styling2>
            <clock-element tickRate=2000></clock-element>
            <my-context-app>
                <my-context-element></my-context-element>
            </my-context-app>

        """
        let rootPart = Lit.render (content, el)
        ()

do start ()
