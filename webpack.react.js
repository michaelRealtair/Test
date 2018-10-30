var path = require('path');

module.exports = {
  entry: './Scripts/index.js',
  output: {
    path: path.resolve('Scripts/generated'),
    filename: 'Framework.js',
    libraryTarget: 'commonjs2'
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
}