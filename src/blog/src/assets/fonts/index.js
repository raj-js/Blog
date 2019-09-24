import { createGlobalStyle } from 'styled-components'

export const Icons = createGlobalStyle`
  @font-face {font-family: "iconfont";
    src: url('iconfont.eot?t=1569287340083'); /* IE9 */
    src: url('iconfont.eot?t=1569287340083#iefix') format('embedded-opentype'), /* IE6-IE8 */
    url('data:application/x-font-woff2;charset=utf-8;base64,d09GMgABAAAAAAL4AAsAAAAABqgAAAKrAAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHEIGVgCCcAqBNIFGATYCJAMICwYABCAFhG0HLhvqBRHVk1FkXybwMkTytbNEVf9EKFcVNKykv1ARqHM+3+KJNJHgmeD58o/33N39AkqClRwAdSYtNP1vY7dE/RpABqjT/q9piYVOXz2CQw+bPkoOOD9FP3XKj/oIkPlfA1DAyiuBzgA4OGa6KB9IHtBcsgIjAQc2HVhU/DfZP8gD+A9jNxE4hNMQwJFQkpGSY00L9hjAJAFkxh0fxD7nxmCsmD2Cbc1Kg5zABnt1UAXH+e/LV8UeFDYaUNAwVjpCwccrMEFr2UMReEDQ1tsAGkgGDEhLbbgOjVhEjWPYEAn7yhX4+G1Ntche/3mILSDbGYBglX1PHMy91WwFgJHd2UDrqP6gEj3WXrz4dNx+GcWKnj27Xnie6zMz8ayP03m/iy8BIXsu7uY+6AUduvPkf+fNp3ez24//dlx7dGvWnuDi8fHi4Pzvme2qJrLDEyCDMsgNndTx37sgezz9S6gMbDXbgOSJ5ubp5DdiMEYiDiiPl/JbXO917mNeH/n4XABY6+Wi6w/9Gzq609/9bjn/7Z0MAK9/jl5SndaGflawP61F4PdxejaZkAc0yvicWqsie9REBTjiCFjodk8+jJX73GtcsMfnjq12hKSgsScaabDJYIMTKWCLPfngSBLl653wYhaNGAcgkb0KCO5cBYUr26Bx5z7SYN+DDb58B1vcRYMjbeK1oxOxgriNHaMuaIHxAteMI0I6aYjcM9q3QOcsj5M+kZXrg1F/WIydMEKeY46622MRAuI4hKNyHgZBDAnHHprSd0SS9WBAdd/UN+Mw12DHqAtaYLzANeOIaGdplH7+jPYt0LmlbED/iazc3mHUH/ZAnsRRr7J7eY2622MRAuI4hKNixACGY0jqh3loSt8ZEUzWA60d9RX315eGH5BlVQEUBJZqSgsKOZcDAA==') format('woff2'),
    url('iconfont.woff?t=1569287340083') format('woff'),
    url('iconfont.ttf?t=1569287340083') format('truetype'), /* chrome, firefox, opera, Safari, Android, iOS 4.2+ */
    url('iconfont.svg?t=1569287340083#iconfont') format('svg'); /* iOS 4.1- */
  }

  .iconfont {
    font-family: "iconfont" !important;
    font-size: 16px;
    font-style: normal;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
  }

  .icon-user:before {
    content: "\\e7ae";
  }
`