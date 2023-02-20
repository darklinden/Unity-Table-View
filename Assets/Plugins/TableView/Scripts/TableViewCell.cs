﻿/****************************************************************************
 Copyright (c) hiepndhut@gmail.com
 Copyright (c) 2018 No PowerUp
 
 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:
 
 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.
 
 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.
 ****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UITableView
{
    public class TableViewCell : MonoBehaviour
    {
        public string reuseIdentifier;

        private void Awake()
        {
            m_Rect = GetComponent<RectTransform>();
        }

        private RectTransform m_Rect;
        public RectTransform Rect => m_Rect != null ? m_Rect : m_Rect = GetComponent<RectTransform>();

        public int Section { get; set; }

        public int Row { get; set; }

        public void SetIndex(int section, int row)
        {
            Section = section;
            Row = row;
        }
    }
}