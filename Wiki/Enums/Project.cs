﻿namespace Wiki
{
    using System.ComponentModel;

    public enum Project
    {
        /// <summary>Multilingual project to build free encyclopedia
        /// articles in all languages of the world.</summary>
        [Url("https://xx.wikipedia.org")]
        Wikipedia,

        /// <summary>Multilingual project to create a free content 
        /// dictionary of all words.</summary>
        [Url("https://xx.wiktionary.org")]
        Wiktionary,

        /// <summary>Multilingual project to produce quotations taken
        /// from famous people, books, films and other materials.</summary>
        [Url("https://xx.wikiquote.org")]
        Wikiquote,

        /// <summary>Multilingual project to build a collection 
        /// of free content resources.</summary>
        [Url("https://xx.wikibooks.org")]
        Wikibooks,

        /// <summary>Multilingual project to archive a collection
        /// of free and open content texts.</summary>
        [Url("https://xx.wikisource.org")]
        Wikisource,

        /// <summary>Multilingual project to report free content 
        /// and fact-checked news on a wide variety of subjects.</summary>
        [Url("https://xx.wikinews.org")]
        Wikinews,

        /// <summary>Multilingual project dedicated to learning 
        /// materials and learning communities, as well as research.</summary>
        [Url("https://xx.wikiversity.org")]
        Wikiversity,

        /// <summary>Multilingual project to create a free,
        /// complete and up-to-date worldwide travel guide.</summary>
        [Url("https://xx.wikivoyage.org")]
        Wikivoyage,

        /// <summary>Monolingual project to create a free linked 
        /// database that can be read and edited by both humans and machines.</summary>
        [Url("https://www.wikidata.org")]
        Wikidata,

        /// <summary>Monolingual project to provide a free central 
        /// repository for images, sounds, videos and other media files.</summary>
        [Url("https://commons.wikimedia.org")]
        Wikicommons,

        /// <summary>Monolingual project to provide a free 
        /// directory of species data on all forms of life.</summary>
        [Url("https://species.wikimedia.org")]
        Wikispecies,
    }
}