using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RtfPdfCreator.ViewModels
{
    public class RtfEditorViewModel : BindableBase
    {
        public RtfEditorViewModel()
        {
            string rtfString = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1049
{\fonttbl{\f0\fswiss\fprq2\fcharset0 Arial;}
{\f1\fswiss\fcharset0 Arial;}}
{\colortbl ;\red0\green0\blue255;}
\viewkind4\uc1\pard\cf1\lang1033\b\f0\fs32 Test.\cf0\b0\f1\fs20\par}";
            RtfContent = rtfString;
        }

        private string _rtfContent;

        public string RtfContent
        {
            get => _rtfContent;
            set => SetProperty(ref _rtfContent, value);
        }

    }
}
