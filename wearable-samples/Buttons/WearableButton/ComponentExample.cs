/*
 * Copyright (c) 2020 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using Tizen.NUI;
using Tizen.NUI.Components;

public class ComponentExample : NUIApplication
{
    public ComponentExample() : base()
    {
    }

    protected override void OnCreate()
    {
        base.OnCreate();

        // Set theme to wearable.
        // (It is not needed in the wearable device)
        Tizen.NUI.Components.StyleManager.Instance.Theme = "wearable";

        Window window = NUIApplication.GetDefaultWindow();
        window.BackgroundColor = Color.Black;        

        // Create a button with
        var button = new Button()
        {
            Text = "Hello World!",
            Size = new Size(210, 72),

            // Positioning it to the bottom
            ParentOrigin = ParentOrigin.BottomCenter,
            PivotPoint = PivotPoint.BottomCenter,
            PositionUsesPivotPoint = true,
            Position = new Position(0, -20)
        };
        window.Add(button);
    }

    static void Main(string[] args)
    {
        ComponentExample example = new ComponentExample();
        example.Run(args);
    }
}
