var path = require("path");

var config = {
  context: path.join(__dirname, '/Scripts'),
  entry: {
    app: './index.js'
  },
  output: {
    path: path.join(__dirname, "../../../Realtair.Framework/Realtair.Framework.Core.Web/Content/staging/js"),
    filename: "pitch.js",
    library: 'Realtair'
  },
  devServer: {
    contentBase: __dirname, // `__dirname` is root of the project
    port: '3003'
  },
  module: {
    rules: [
      {
        test: /\.js$/,
        loader: 'babel-loader',
        exclude: /node_modules/,
        query: {
          presets: ['es2015', 'react'],
          plugins: ['transform-decorators-legacy', 'transform-class-properties', 'transform-object-rest-spread']
        }
      },
      {
        test: /\.jsx$/,
        loader: 'babel-loader',
        exclude: /node_modules/,
        query: {
          presets: ['es2015', 'react'],
          plugins: ['transform-decorators-legacy', 'transform-class-properties', 'transform-object-rest-spread']
        }
      },
      {
        test: /\.css$/,
        use: ["style-loader", "css-loader"]
      },
      {
        test: /\.(pdf|jpg|png|gif|svg|ico)$/,
        use: [
          {
            loader: 'url-loader'
          },
        ]
      }
    ]
  },

  resolve: {
    extensions: ['.js', '.jsx'],
  }
};

module.exports = config;
